// Auto-generated from FunctionGenerator.fsx

[<AutoOpen>]
module Squple.Values

let values1 (a: Selectable<'a>) (query: Query<'ret, unit>) : Query<'ret, ('a)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a ]
    readRow = query.readRow
  }

let values2 (a: Selectable<'a>, b: Selectable<'b>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b ]
    readRow = query.readRow
  }

let values3 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c ]
    readRow = query.readRow
  }

let values4 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d ]
    readRow = query.readRow
  }

let values5 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e ]
    readRow = query.readRow
  }

let values6 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f ]
    readRow = query.readRow
  }

let values7 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g ]
    readRow = query.readRow
  }

let values8 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h ]
    readRow = query.readRow
  }

let values9 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i ]
    readRow = query.readRow
  }

let values10 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j ]
    readRow = query.readRow
  }

let values11 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k ]
    readRow = query.readRow
  }

let values12 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l ]
    readRow = query.readRow
  }

let values13 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m ]
    readRow = query.readRow
  }

let values14 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n ]
    readRow = query.readRow
  }

let values15 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o ]
    readRow = query.readRow
  }

let values16 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p ]
    readRow = query.readRow
  }

let values17 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q ]
    readRow = query.readRow
  }

let values18 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r ]
    readRow = query.readRow
  }

let values19 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s ]
    readRow = query.readRow
  }

let values20 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t ]
    readRow = query.readRow
  }

let values21 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>, u: Selectable<'u>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't * 'u)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t; u ]
    readRow = query.readRow
  }

let values22 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>, u: Selectable<'u>, v: Selectable<'v>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't * 'u * 'v)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t; u; v ]
    readRow = query.readRow
  }

let values23 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>, u: Selectable<'u>, v: Selectable<'v>, w: Selectable<'w>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't * 'u * 'v * 'w)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t; u; v; w ]
    readRow = query.readRow
  }

let values24 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>, u: Selectable<'u>, v: Selectable<'v>, w: Selectable<'w>, x: Selectable<'x>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't * 'u * 'v * 'w * 'x)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t; u; v; w; x ]
    readRow = query.readRow
  }

let values25 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>, u: Selectable<'u>, v: Selectable<'v>, w: Selectable<'w>, x: Selectable<'x>, y: Selectable<'y>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't * 'u * 'v * 'w * 'x * 'y)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t; u; v; w; x; y ]
    readRow = query.readRow
  }

let values26 (a: Selectable<'a>, b: Selectable<'b>, c: Selectable<'c>, d: Selectable<'d>, e: Selectable<'e>, f: Selectable<'f>, g: Selectable<'g>, h: Selectable<'h>, i: Selectable<'i>, j: Selectable<'j>, k: Selectable<'k>, l: Selectable<'l>, m: Selectable<'m>, n: Selectable<'n>, o: Selectable<'o>, p: Selectable<'p>, q: Selectable<'q>, r: Selectable<'r>, s: Selectable<'s>, t: Selectable<'t>, u: Selectable<'u>, v: Selectable<'v>, w: Selectable<'w>, x: Selectable<'x>, y: Selectable<'y>, z: Selectable<'z>) (query: Query<'ret, unit>) : Query<'ret, ('a * 'b * 'c * 'd * 'e * 'f * 'g * 'h * 'i * 'j * 'k * 'l * 'm * 'n * 'o * 'p * 'q * 'r * 's * 't * 'u * 'v * 'w * 'x * 'y * 'z)> = 
  { queryTemplate = query.queryTemplate
    selectColumns = query.selectColumns
    valueColumns = [ a; b; c; d; e; f; g; h; i; j; k; l; m; n; o; p; q; r; s; t; u; v; w; x; y; z ]
    readRow = query.readRow
  }

