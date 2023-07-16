open System.IO
open System

seq {
  $"// Auto-generated from {__SOURCE_FILE__}"
  ""
  "[<AutoOpen>]"
  "module Squple.Templates"
  ""
  for i in 1..26 do
    let letters = List.init i (char >> (+) 'a')
    let parameters = letters |> List.map (fun l -> $"{l}: Selectable<'{l}>") |> String.concat ", "
    let retType = letters |> List.map (fun l -> $"'{l}") |> String.concat " * "
    let readFuncs = letters |> List.map (fun l -> $"read{l}") |> String.concat ", "
    let readColumnTs = letters |> List.map (fun l -> $"readColumnT<'{l}>") |> String.concat ", "
    let selectColumns = String.concat "; " (List.map string letters)
    let readCalls = letters |> List.mapi (fun i l -> $"read{l} reader {i}") |> String.concat ", "
    $"let sql{i} ({parameters}) (queryTemplate: string) : Query<({retType}), unit> = "
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
  for i in 1..26 do
    let letters = List.init i (char >> (+) 'a')
    let parameters = letters |> List.map (fun l -> $"{l}: Selectable<'{l}>") |> String.concat ", "
    let paramsType = letters |> List.map (fun l -> $"'{l}") |> String.concat " * "
    let valueColumns = String.concat "; " (List.map string letters)
    $"let values{i} ({parameters}) (query: Query<'ret, unit>) : Query<'ret, ({paramsType})> = "
    $"  {{ queryTemplate = query.queryTemplate"
    $"    selectColumns = query.selectColumns"
    $"    valueColumns = [ {valueColumns} ]"
    $"    readRow = query.readRow"
    $"  }}"
    $""
}
//|> Seq.iter (printfn "%s")
|> fun s -> File.WriteAllLines(Path.Combine(__SOURCE_DIRECTORY__, "ValuesFunctions.fs"), s)
