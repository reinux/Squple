open System.IO
open System

let nQueryFunctions = 100
let nValuesFunctions = 100

let colNumToName uppercase i =
    let a = if uppercase then 'A' else 'a'
    (i - 1)
    |> Array.unfold (fun n -> if n >= 0
                              then Some ((a + char (n % 26)),
                                         (n / 26 - 1))
                              else None)
    |> Array.rev
    |> System.String
    
seq {
  $"// Auto-generated from {__SOURCE_FILE__}"
  ""
  "[<AutoOpen>]"
  "module Squple.Templates"
  ""
  for n in 1..nQueryFunctions do
    let letters = [ for i in 1..n do $"_{colNumToName false i}" ]
    let parameters = letters |> List.map (fun l -> $"{l}: Selectable<'{l}>") |> String.concat ", "
    let retType = letters |> List.map (fun l -> $"'{l}") |> String.concat " * "
    let readFuncs = letters |> List.map (fun l -> $"read{l}") |> String.concat ", "
    let readColumnTs = letters |> List.map (fun l -> $"readColumnT<'{l}>") |> String.concat ", "
    let selectColumns = String.concat "; " (List.map (sprintf "%s") letters)
    let readCalls = letters |> List.mapi (fun i l -> $"read{l} reader {i}") |> String.concat ", "
    $"let sql{n} ({parameters}) (queryTemplate: string) : Query<({retType}), unit> = "
    $"  let {readFuncs} = {readColumnTs}"
    $"  {{ queryTemplate = queryTemplate"
    $"    selectColumns = [ {selectColumns} ]"
    $"    valueColumns = []"
    $"    readRow ="
    $"      fun reader ->"
    $"        {readCalls}"
    $"  }}"
    $""
}
|> fun s -> File.WriteAllLines(Path.Combine(__SOURCE_DIRECTORY__, "TemplateFunctions.fs"), s)

seq {
  $"// Auto-generated from {__SOURCE_FILE__}"
  ""
  "[<AutoOpen>]"
  "module Squple.Values"
  ""
  for n in 1..nValuesFunctions do
    let letters = [ for i in 1..n do $"_{colNumToName false i}" ]
    let parameters = letters |> List.map (fun l -> $"{l}: Selectable<'{l}>") |> String.concat ", "
    let paramsType = letters |> List.map (fun l -> $"'{l}") |> String.concat " * "
    let valueColumns = String.concat "; " (List.map string letters)
    $"let values{n} ({parameters}) (query: Query<'ret, unit>) : Query<'ret, ({paramsType})> = "
    $"  {{ queryTemplate = query.queryTemplate"
    $"    selectColumns = query.selectColumns"
    $"    valueColumns = [ {valueColumns} ]"
    $"    readRow = query.readRow"
    $"  }}"
    $""
}
//|> Seq.iter (printfn "%s")
|> fun s -> File.WriteAllLines(Path.Combine(__SOURCE_DIRECTORY__, "ValuesFunctions.fs"), s)
