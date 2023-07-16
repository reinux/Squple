[<AutoOpen>]
module Squple.Core

//#nowarn "86"

open System.Data
open System.Text.RegularExpressions
open System.Data.Common
open System
open System.Threading.Tasks
open System.Reflection.Metadata.Ecma335

type Table = Table of name: string
  with override x.ToString() = let (Table name) = x in name

type AnyQueryArg =
  abstract QueryArg: QueryArg<obj>
  abstract Key: string
  abstract Value: obj

and QueryArg<'t> =
  | QueryArg of string * 't
  override x.ToString() = let (QueryArg (name, _)) = x in name
  member x.Key = let (QueryArg (name, _)) = x in x
  member x.Value = let (QueryArg (_, v)) = x in v
  interface AnyQueryArg with
    member x.QueryArg =
      let (QueryArg (name, x)) = x in QueryArg (name, x :> obj)
    member x.Key =
      let (QueryArg (name, _)) = x in name
    member x.Value =
      let (QueryArg (_, v)) = x in v :> obj
  //member x.Cast<'q> =
  //  match x with
  //  | QueryArg s -> QueryArg<'q> s

let arg name v = QueryArg(name, v)

[<NoEquality; NoComparison>]
type Selectable<'a> =
  | Col of table: Table * col: string
  | Expr of string
  | Aliased of Selectable<'a> * name: string

  static member inline Cast<'a, 'b>(s: Selectable<'a>): Selectable<'b> =
    match s with
    | Col (t, c) -> Col(t, c)
    | Expr s -> Expr s
    | Aliased (Col (t, n), n') -> Aliased (Col (t, n), n')
    | Aliased (Expr s, n') -> Aliased (Expr s, n')
    | Aliased (Aliased _, _) -> failwith "Cannot alias a column more than once"

  static member inline (~~)(x: Selectable<'a>): Selectable<'a option> =
    Selectable.Cast x

  static member (@=) (a: Selectable<'x>, b: Selectable<'x>) =                 $"{a} = {b}"
  static member (@=) (a: Selectable<'x>, b: QueryArg<'x>) =                   $"{a} = {b}"
  static member (@=) (a: Selectable<'x option>, b: Selectable<'x>) =          $"{a} = {b}"
  static member (@=) (a: Selectable<'x option>, b: QueryArg<'x>) =            $"{a} = {b}"
  static member (@=?) (a: Selectable<'x>, b: Selectable<'x option>) =         $"{a} = {b}"
  static member (@=?) (a: Selectable<'x>, b: QueryArg<'x option>) =           $"{a} = {b}"
  static member (@=?) (a: Selectable<'x option>, b: Selectable<'x option>) =  $"{a} = {b}"
  static member (@=?) (a: Selectable<'x option>, b: QueryArg<'x option>) =    $"{a} = {b}"
  //static member (?@=?) (a: Selectable<'a option>, b: Selectable<'a option>) =         $"{a} = {b}"
  //static member (?@=?) (a: Selectable<'a option>, b: QueryArg<'a option>) =           $"{a} = {b}"
  //static member (?@=?) (a: Selectable<'a option>, b: Selectable<'a option>) =  $"{a} = {b}"
  //static member (?@=?) (a: Selectable<'a option>, b: QueryArg<'a option>) =    $"{a} = {b}"

  static member (@<) (a: Selectable<'x>, b: Selectable<'x>) =                 $"{a} < {b}"
  static member (@<) (a: Selectable<'x>, b: QueryArg<'x>) =                   $"{a} < {b}"
  static member (@<) (a: Selectable<'x option>, b: Selectable<'x>) =          $"{a} < {b}"
  static member (@<) (a: Selectable<'x option>, b: QueryArg<'x>) =            $"{a} < {b}"
  static member (@<?) (a: Selectable<'x>, b: Selectable<'x option>) =         $"{a} < {b}"
  static member (@<?) (a: Selectable<'x>, b: QueryArg<'x option>) =           $"{a} < {b}"
  static member (@<?) (a: Selectable<'x option>, b: Selectable<'x option>) =  $"{a} < {b}"
  static member (@<?) (a: Selectable<'x option>, b: QueryArg<'x option>) =    $"{a} < {b}"

  static member op_AtGreater (a: Selectable<'x>, b: Selectable<'x>) =         $"{a} > {b}"
  static member op_AtGreater (a: Selectable<'x>, b: QueryArg<'x>) =           $"{a} > {b}"
  static member op_AtGreater (a: Selectable<'x option>, b: Selectable<'x>) =  $"{a} > {b}"
  static member op_AtGreater (a: Selectable<'x option>, b: QueryArg<'x>) =    $"{a} > {b}"
  static member (@>?) (a: Selectable<'x>, b: Selectable<'x option>) =         $"{a} > {b}"
  static member (@>?) (a: Selectable<'x>, b: QueryArg<'x option>) =           $"{a} > {b}"
  static member (@>?) (a: Selectable<'x option>, b: Selectable<'x option>) =  $"{a} > {b}"
  static member (@>?) (a: Selectable<'x option>, b: QueryArg<'x option>) =    $"{a} > {b}"
  
  static member (@+>) (a: Selectable<'x>, b: Selectable<'x>) =                 $"{a} > {b}"
  static member (@+>) (a: Selectable<'x>, b: QueryArg<'x>) =                   $"{a} > {b}"
  static member (@+>) (a: Selectable<'x option>, b: Selectable<'x>) =          $"{a} > {b}"
  static member (@+>) (a: Selectable<'x option>, b: QueryArg<'x>) =            $"{a} > {b}"

  static member (@<=) (a: Selectable<'x>, b: Selectable<'x>) =                $"{a} <= {b}"
  static member (@<=) (a: Selectable<'x>, b: QueryArg<'x>) =                  $"{a} <= {b}"
  static member (@<=) (a: Selectable<'x option>, b: Selectable<'x>) =         $"{a} <= {b}"
  static member (@<=) (a: Selectable<'x option>, b: QueryArg<'x>) =           $"{a} <= {b}"
  static member (@<=?) (a: Selectable<'x>, b: Selectable<'x option>) =        $"{a} <= {b}"
  static member (@<=?) (a: Selectable<'x>, b: QueryArg<'x option>) =          $"{a} <= {b}"
  static member (@<=?) (a: Selectable<'x option>, b: Selectable<'x option>) = $"{a} <= {b}"
  static member (@<=?) (a: Selectable<'x option>, b: QueryArg<'x option>) =   $"{a} <= {b}"

  static member (@>=) (a: Selectable<'x>, b: Selectable<'x>) =                $"{a} >= {b}"
  static member (@>=) (a: Selectable<'x>, b: QueryArg<'x>) =                  $"{a} >= {b}"
  static member (@>=) (a: Selectable<'x option>, b: Selectable<'x>) =         $"{a} >= {b}"
  static member (@>=) (a: Selectable<'x option>, b: QueryArg<'x>) =           $"{a} >= {b}"
  static member (@>=?) (a: Selectable<'x>, b: Selectable<'x option>) =        $"{a} >= {b}"
  static member (@>=?) (a: Selectable<'x>, b: QueryArg<'x option>) =          $"{a} >= {b}"
  static member (@>=?) (a: Selectable<'x option>, b: Selectable<'x option>) = $"{a} >= {b}"
  static member (@>=?) (a: Selectable<'x option>, b: QueryArg<'x option>) =   $"{a} >= {b}"

  static member (@<>) (a: Selectable<'x>, b: Selectable<'x>) =                $"{a} <> {b}"
  static member (@<>) (a: Selectable<'x>, b: QueryArg<'x>) =                  $"{a} <> {b}"
  static member (@<>) (a: Selectable<'x option>, b: Selectable<'x>) =         $"{a} <> {b}"
  static member (@<>) (a: Selectable<'x option>, b: QueryArg<'x>) =           $"{a} <> {b}"
  static member (@<>?) (a: Selectable<'x>, b: Selectable<'x option>) =        $"{a} <> {b}"
  static member (@<>?) (a: Selectable<'x>, b: QueryArg<'x option>) =          $"{a} <> {b}"
  static member (@<>?) (a: Selectable<'x option>, b: Selectable<'x option>) = $"{a} <> {b}"
  static member (@<>?) (a: Selectable<'x option>, b: QueryArg<'x option>) =   $"{a} <> {b}"

  interface AnySelectable with
    member x.Selectable = Selectable.Cast(x)

  override x.ToString() =
    match x with
    | Col (t, n) -> $"{t}.{n}"
    | Expr e -> e
    | Aliased (a, n) -> $"{a} AS {n}"
  
  member x.ColName =
    match x with
    | Col (_, n) -> n
    | Expr e -> failwith "Expression does not have a column name"
    | Aliased (_, n) -> n

  member x.As(name: string) =
    Aliased(x, name)

  member x.From(table: Table) : Selectable<'a> =
    match x with
    | Col (_, n) -> Col(table, n)
    | Expr e -> failwith "Cannot take expression from table"
    | Aliased (_, n) -> Aliased (x.From table, n)

and AnySelectable =
  abstract Selectable: Selectable<obj>

let col<'t> table col: Selectable<'t> = Col(table, col)

let table name = Table name

let expr<'t> s: Selectable<'t> = Expr s

let alias name col = Aliased (col, name)

let rec colNameOnly (selectable:AnySelectable) =
  match selectable.Selectable with
  | Col (_, n) -> Expr n
  | Expr _ as e-> e
  | Aliased (a, n) -> colNameOnly a

type Query<'ret, 'parameters> = {
  queryTemplate: string
  selectColumns: AnySelectable list
  valueColumns: AnySelectable list
  readRow: IDataReader -> 'ret
}

let writeConverters = Collections.Generic.Dictionary<Type, (obj -> obj)>()

let tryFindWriteConverter (v: obj) =
  match writeConverters.TryGetValue(v.GetType()) with
  | true, f ->
    Some f
  | false, _ ->
    // TODO: look for the most direct parent type as opposed to the first one in the dictionary
    match writeConverters |> Seq.tryFind (fun kvp -> kvp.Key.IsInstanceOfType v) with
    | None -> None
    | Some kvp ->
      writeConverters.TryAdd(kvp.Key, kvp.Value) |> ignore
      Some kvp.Value

let addWriteConverter<'t, 'q> (f: 't -> 'q) =
  writeConverters.Add(typeof<'t>, (fun x -> f (x :?> 't)))

  // TODO: cache these converters
let rec convWrite v =
  match v with
  | null -> DBNull.Value :> obj
  | v ->
      let t = v.GetType()
      if (v :> obj) = null then
        DBNull.Value :> obj
      elif t.IsGenericType
           && t.GetGenericTypeDefinition() = typedefof<_ option> then
        match t.GetGenericArguments() with
        | [||] -> DBNull.Value :> obj
        | [| some |] -> convWrite <| t.GetProperty("Value").GetValue v
        | _ -> failwith "Error converting argument for write to database: option has more than one generic argument"
        // TODO: convert arrays... more complicated than it seems
      //elif v :? Array then
      //  [| for a in v :?> Array do convWrite a |]
      else
        match tryFindWriteConverter (v) with
        | Some f ->
          f v
        | None ->
          if t.IsEnum then
            let t' = Enum.GetUnderlyingType(t)
            Convert.ChangeType(v, t')
          else v

let readConverters = Collections.Generic.Dictionary<Type, (IDataReader -> int -> obj)>()

let addReadConverter<'t> (c: IDataReader -> int -> 't) =
  readConverters.Add((typeof<'t>, (fun r i -> c r i |> box)))

let private mkconverter<'dbtype, 't> f (r: 'dbtype -> 't) (w: 't -> 'dbtype) =
  addReadConverter (fun dr i -> f dr i |> r)
  addWriteConverter w

module DataReader =
  let getInt16 (r: IDataReader) = r.GetInt16
  let getInt32 (r: IDataReader) = r.GetInt32
  let getInt64 (r: IDataReader) i = r.GetInt64 i
  let getDouble (r: IDataReader) = r.GetDouble
  let getDecimal (r: IDataReader) = r.GetDecimal
  let getBoolean (r: IDataReader) = r.GetBoolean
  let getObj (r: IDataReader) (i: int) = r.[i]
  let getName (r: IDataReader) = r.GetName
  let getDateTime (r: IDataReader) = r.GetDateTime
  let isDbNull (r: IDataReader) = r.IsDBNull
  let getValue (r: IDataReader) = r.GetValue
  let read (r: IDataReader) = r.Read()
  let getString (r: IDataReader) i =
    if r.IsDBNull i then null
    else
      try r.GetString i
      with :? InvalidCastException as e ->
        let o = (getObj (r: IDataReader) i).ToString()
        o

let addi16Converter r w = mkconverter DataReader.getInt16 r w
let addi32Converter r w = mkconverter DataReader.getInt32 r w
let addi64Converter r w = mkconverter DataReader.getInt64 r w
let addFloatConverter r w = mkconverter DataReader.getDouble r w
let addBoolConverter r w = mkconverter DataReader.getBoolean r w
let addDecimalConverter r w = mkconverter DataReader.getDecimal r w
let addObjConverter r w = mkconverter DataReader.getObj r w
let addDateTimeConverter r w = mkconverter DataReader.getDateTime r w
let addStringConverter r w = mkconverter DataReader.getString r w
let addByteArrayConverter r w = mkconverter (fun r i -> DataReader.getObj r i :?> byte array) r w

mkconverter DataReader.getInt32 uint int

addReadConverter (DataReader.getInt16)
addReadConverter (DataReader.getInt64)
addReadConverter (DataReader.getInt32)
addReadConverter (DataReader.getDouble)
addReadConverter (DataReader.getDecimal)
addReadConverter (DataReader.getString)
addReadConverter (fun r i -> DataReader.getObj r i :?> byte array)
addReadConverter (DataReader.getBoolean)

addReadConverter (fun r i ->
  DateTime.SpecifyKind(DataReader.getDateTime r i, DateTimeKind.Utc))

addReadConverter (fun r i -> DataReader.getObj r i)
addWriteConverter (fun (dt: DateTime) -> dt.ToUniversalTime())

addObjConverter unbox<TimeSpan> box
addObjConverter (unbox<TimeSpan> >> TimeOnly.FromTimeSpan) (fun (t: TimeOnly) ->  t.ToTimeSpan())
addObjConverter (unbox<DateTime> >> DateOnly.FromDateTime) box

let opttype =
  typeof<int option>.GetGenericTypeDefinition()

let rec readColumnT<'t> : (IDataReader -> int -> 't) =
  let t = typeof<'t>
  let isOption, t =
    if t.IsGenericType
       && t.GetGenericTypeDefinition() = opttype then
      true, t.GetGenericArguments().[0]
    else
      false, t

  if isOption && t.IsGenericType && t.GetGenericTypeDefinition() = opttype then
    failwith "Nesting options is not currently supported."

  match readConverters.TryGetValue(t) with
  // TODO: unflatten nested options
  | true, c when isOption ->
      let some =
        let t =
          typeof<option<unit>>.GetGenericTypeDefinition().MakeGenericType(t)

        Reflection.FSharpType.GetUnionCases(t).[1]

      fun (r:IDataReader) i ->
        if r.IsDBNull(i) then
          None |> box :?> 't
        else
          Reflection.FSharpValue.MakeUnion(some, [| c r i |]) :?> 't
  | true, c -> fun r i -> c r i :?> 't
  | false, _ when t.IsEnum ->
      if isOption then
        fun r i ->
          if r.IsDBNull(i) then
            None |> box :?> 't
          else
            let o = Enum.ToObject(t, r.GetInt32(i))

            let some =
              let t =
                typeof<option<unit>>.GetGenericTypeDefinition()
                  .MakeGenericType(o.GetType())

              Reflection.FSharpType.GetUnionCases(t).[1]

            Reflection.FSharpValue.MakeUnion(some, [| o |]) :?> 't
      else
        fun r i ->
          Enum.ToObject(t, r.GetInt32(i)) :?> 't
  | false, _ ->
      raise <| NotImplementedException ($"No read converter for type {t} (Is option: {isOption})")

let sql0 (queryTemplate: string) : Query<unit, unit> =
  { queryTemplate = queryTemplate
    selectColumns = []
    valueColumns = []
    readRow = fun _ -> ()
  }

let templateRegex = Regex(@"\!selection|\!columns|\!values|\!set", RegexOptions.Compiled)
let mkQueryString (query: Query<'ret, 'parameters>) =
  templateRegex.Replace(query.queryTemplate,
    fun m ->
      match m.Value with
      | "!selection" ->
        query.selectColumns |> List.map string |> String.concat ", "
      | "!columns" ->
        query.valueColumns |> List.map (fun c ->
          match c.Selectable with
          | Col (t, n) -> n
          | a -> failwith $"Column list contains non-column entry: {a}"
        ) |> String.concat ", "
      | "!values" ->
        Seq.init query.valueColumns.Length (char >> (+) 'a' >> sprintf "@_%c")
        |> String.concat ", "
      | "!set" ->
        query.valueColumns
        |> List.mapi (fun i c -> $"{colNameOnly c} = @_{'a' + (char) i}")
        |> String.concat ", "
      | x -> x)

let prepareCommand (conn: DbConnection, tx: DbTransaction option) (query: Query<'ret, 'parameters>) =
  let sqlstr = mkQueryString query
  let cmd = conn.CreateCommand(CommandText = sqlstr)
  Option.iter (fun tx -> cmd.Transaction <- tx) tx
  cmd

// TODO: correct way to cache parameters?

let setArgs (cmd: DbCommand) (args: 'parameters) (additionalArgs: AnyQueryArg list) =
  let args =
    if Reflection.FSharpType.IsTuple(typeof<'parameters>) then
      Reflection.FSharpValue.GetTupleFields(args)
      |> Seq.mapi (fun i a -> (arg $"@_{(char) i + 'a'}" a) :> AnyQueryArg)
    elif typeof<'parameters> = typeof<unit> then []
    else [ (arg "@_a" args) :> AnyQueryArg ]
    |> Seq.append additionalArgs
  for arg in args do
    let v = convWrite arg.Value
    cmd.CreateParameter(ParameterName = arg.Key, Value = v)
    |> cmd.Parameters.Add
    |> ignore

let execNonQ conn additionalArgs (args: 'parameters) (query:Query<'ret, 'parameters>) : int =
    use cmd = prepareCommand conn query
    setArgs cmd args additionalArgs
    cmd.ExecuteNonQuery()

let execNonQAsync conn additionalArgs (args: 'parameters) (query:Query<'ret, 'parameters>) : Task<int> =
    use cmd = prepareCommand conn query
    setArgs cmd args additionalArgs
    cmd.ExecuteNonQueryAsync()

let execList conn additionalArgs (args: 'parameters) (query:Query<'ret, 'parameters>) : 'ret list =
    use cmd = prepareCommand conn query
    setArgs cmd args additionalArgs
    use reader = cmd.ExecuteReader()
    [ while reader.Read() do
        query.readRow reader
    ]

let execListAsync conn additionalArgs (args: 'parameters) (query:Query<'ret, 'parameters>) : Task<'ret list> =
  let results = ResizeArray()
  let rec readRow (reader:DbDataReader) = task {
    let! success = reader.ReadAsync()
    if success then
      results.Add(query.readRow reader)
      return! readRow reader
  }
  task {
    use cmd = prepareCommand conn query
    setArgs cmd args additionalArgs
    use! reader = cmd.ExecuteReaderAsync()
    do! readRow reader
    return results |> Seq.toList
}

let execHead conn additionalArgs (args: 'parameters) (query:Query<'ret, 'parameters>) : 'ret =
    use cmd = prepareCommand conn query
    setArgs cmd args additionalArgs
    use reader = cmd.ExecuteReader()
    reader.ReadAsync() |> ignore
    query.readRow reader

let execHeadAsync conn additionalArgs (args: 'parameters) (query:Query<'ret, 'parameters>) : Task<'ret> = task {
    use cmd = prepareCommand conn query
    setArgs cmd args additionalArgs
    use! reader = cmd.ExecuteReaderAsync()
    let! _ = reader.ReadAsync()
    return query.readRow reader
}
    
let execTryHeadAsync conn additionalArgs (args: 'parameters) (query:Query<'ret, 'parameters>) : Task<'ret option> = task {
    use cmd = prepareCommand conn query
    setArgs cmd args additionalArgs
    use! reader = cmd.ExecuteReaderAsync()
    let! readResult = reader.ReadAsync()
    return if readResult = true then
             Some (query.readRow reader)
           else
             None
}

let execTryHead conn additionalArgs (args: 'parameters) (query:Query<'ret, 'parameters>) : 'ret option =
    use cmd = prepareCommand conn query
    setArgs cmd args additionalArgs
    use reader = cmd.ExecuteReader()
    if reader.Read() then Some (query.readRow reader) else None
