// Auto-generated from FunctionGenerator.fsx
[<AutoOpen>]
module Squple.Templates

let sql1 (a: Selectable<'a>) (queryTemplate: string) : Query<('a), unit> = 
  let reada = readColumnT<'a>
  { queryTemplate = queryTemplate
    selectColumns = [ a ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0
  }

let sql2 (a: Selectable<'a>, b: Selectable<'b>) (queryTemplate: string) : Query<('a * 'b), unit> = 
  let reada, readb = readColumnT<'a>, readColumnT<'b>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1
  }

let sql3 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>) (queryTemplate: string) : Query<('a * 'b * 'c), unit> = 
  let reada, readb, readc = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2
  }

let sql4 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd), unit> = 
  let reada, readb, readc, readd = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3
  }

let sql5 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e), unit> = 
  let reada, readb, readc, readd, reade = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4
  }

let sql6 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f), unit> = 
  let reada, readb, readc, readd, reade, readf = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5
  }

let sql7 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g), unit> = 
  let reada, readb, readc, readd, reade, readf, readg = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6
  }

let sql8 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7
  }

let sql9 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8
  }

let sql10 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9
  }

let sql11 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10
  }

let sql12 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11
  }

let sql13 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12
  }

let sql14 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm, readn = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>, readColumnT<'n>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12, readn reader 13
  }

let sql15 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm, readn, reado = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>, readColumnT<'n>, readColumnT<'o>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12, readn reader 13, reado reader 14
  }

let sql16 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm, readn, reado, readp = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>, readColumnT<'n>, readColumnT<'o>, readColumnT<'p>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12, readn reader 13, reado reader 14, readp reader 15
  }

let sql17 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm, readn, reado, readp, readq = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>, readColumnT<'n>, readColumnT<'o>, readColumnT<'p>, readColumnT<'q>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12, readn reader 13, reado reader 14, readp reader 15, readq reader 16
  }

let sql18 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm, readn, reado, readp, readq, readr = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>, readColumnT<'n>, readColumnT<'o>, readColumnT<'p>, readColumnT<'q>, readColumnT<'r>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12, readn reader 13, reado reader 14, readp reader 15, readq reader 16, readr reader 17
  }

let sql19 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm, readn, reado, readp, readq, readr, reads = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>, readColumnT<'n>, readColumnT<'o>, readColumnT<'p>, readColumnT<'q>, readColumnT<'r>, readColumnT<'s>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12, readn reader 13, reado reader 14, readp reader 15, readq reader 16, readr reader 17, reads reader 18
  }

let sql20 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm, readn, reado, readp, readq, readr, reads, readt = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>, readColumnT<'n>, readColumnT<'o>, readColumnT<'p>, readColumnT<'q>, readColumnT<'r>, readColumnT<'s>, readColumnT<'t>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12, readn reader 13, reado reader 14, readp reader 15, readq reader 16, readr reader 17, reads reader 18, readt reader 19
  }

let sql21 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>, u: Selectable<'u>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't * 'u), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm, readn, reado, readp, readq, readr, reads, readt, readu = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>, readColumnT<'n>, readColumnT<'o>, readColumnT<'p>, readColumnT<'q>, readColumnT<'r>, readColumnT<'s>, readColumnT<'t>, readColumnT<'u>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t; u ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12, readn reader 13, reado reader 14, readp reader 15, readq reader 16, readr reader 17, reads reader 18, readt reader 19, readu reader 20
  }

let sql22 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>, u: Selectable<'u>, v: Selectable<'v>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't * 'u * 'v), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm, readn, reado, readp, readq, readr, reads, readt, readu, readv = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>, readColumnT<'n>, readColumnT<'o>, readColumnT<'p>, readColumnT<'q>, readColumnT<'r>, readColumnT<'s>, readColumnT<'t>, readColumnT<'u>, readColumnT<'v>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t; u; v ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12, readn reader 13, reado reader 14, readp reader 15, readq reader 16, readr reader 17, reads reader 18, readt reader 19, readu reader 20, readv reader 21
  }

let sql23 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>, u: Selectable<'u>, v: Selectable<'v>, w: Selectable<'w>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't * 'u * 'v * 'w), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm, readn, reado, readp, readq, readr, reads, readt, readu, readv, readw = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>, readColumnT<'n>, readColumnT<'o>, readColumnT<'p>, readColumnT<'q>, readColumnT<'r>, readColumnT<'s>, readColumnT<'t>, readColumnT<'u>, readColumnT<'v>, readColumnT<'w>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t; u; v; w ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12, readn reader 13, reado reader 14, readp reader 15, readq reader 16, readr reader 17, reads reader 18, readt reader 19, readu reader 20, readv reader 21, readw reader 22
  }

let sql24 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>, u: Selectable<'u>, v: Selectable<'v>, w: Selectable<'w>, x: Selectable<'x>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't * 'u * 'v * 'w * 'x), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm, readn, reado, readp, readq, readr, reads, readt, readu, readv, readw, readx = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>, readColumnT<'n>, readColumnT<'o>, readColumnT<'p>, readColumnT<'q>, readColumnT<'r>, readColumnT<'s>, readColumnT<'t>, readColumnT<'u>, readColumnT<'v>, readColumnT<'w>, readColumnT<'x>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t; u; v; w; x ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12, readn reader 13, reado reader 14, readp reader 15, readq reader 16, readr reader 17, reads reader 18, readt reader 19, readu reader 20, readv reader 21, readw reader 22, readx reader 23
  }

let sql25 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>, u: Selectable<'u>, v: Selectable<'v>, w: Selectable<'w>, x: Selectable<'x>, y: Selectable<'y>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't * 'u * 'v * 'w * 'x * 'y), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm, readn, reado, readp, readq, readr, reads, readt, readu, readv, readw, readx, ready = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>, readColumnT<'n>, readColumnT<'o>, readColumnT<'p>, readColumnT<'q>, readColumnT<'r>, readColumnT<'s>, readColumnT<'t>, readColumnT<'u>, readColumnT<'v>, readColumnT<'w>, readColumnT<'x>, readColumnT<'y>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t; u; v; w; x; y ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12, readn reader 13, reado reader 14, readp reader 15, readq reader 16, readr reader 17, reads reader 18, readt reader 19, readu reader 20, readv reader 21, readw reader 22, readx reader 23, ready reader 24
  }

let sql26 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>, u: Selectable<'u>, v: Selectable<'v>, w: Selectable<'w>, x: Selectable<'x>, y: Selectable<'y>, z: Selectable<'z>) (queryTemplate: string) : Query<('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't * 'u * 'v * 'w * 'x * 'y * 'z), unit> = 
  let reada, readb, readc, readd, reade, readf, readg, readh, readi, readj, readk, readl, readm, readn, reado, readp, readq, readr, reads, readt, readu, readv, readw, readx, ready, readz = readColumnT<'a>, readColumnT<'b>, readColumnT<'c>, readColumnT<'d>, readColumnT<'e>, readColumnT<'f>, readColumnT<'g>, readColumnT<'h>, readColumnT<'i>, readColumnT<'j>, readColumnT<'k>, readColumnT<'l>, readColumnT<'m>, readColumnT<'n>, readColumnT<'o>, readColumnT<'p>, readColumnT<'q>, readColumnT<'r>, readColumnT<'s>, readColumnT<'t>, readColumnT<'u>, readColumnT<'v>, readColumnT<'w>, readColumnT<'x>, readColumnT<'y>, readColumnT<'z>
  { queryTemplate = queryTemplate
    selectColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t; u; v; w; x; y; z ]
    valueColumns = []
    readRow =
      fun reader ->
        reada reader 0, readb reader 1, readc reader 2, readd reader 3, reade reader 4, readf reader 5, readg reader 6, readh reader 7, readi reader 8, readj reader 9, readk reader 10, readl reader 11, readm reader 12, readn reader 13, reado reader 14, readp reader 15, readq reader 16, readr reader 17, reads reader 18, readt reader 19, readu reader 20, readv reader 21, readw reader 22, readx reader 23, ready reader 24, readz reader 25
  }

