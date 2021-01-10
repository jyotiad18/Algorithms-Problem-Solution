/* Topological sort 
start = [1, 2, 3, 4]
graphs = [[1, 2], [1, 3],[3, 2],[4,2], [4,3]];
output = [4, 1, 3, 2]
*/

function topologicalSort(start, arr)
{
   const visited = [];
   const obj = {};
   const result = [];
   setObject(arr, obj);
   for(const s of start)
   {
       if (visited.includes(s)) { continue; }
       helper(visited, obj, s, result);
   }
   console.log(result.reverse());
}

function setObject(arr, obj)
{
   for(const _a of arr)
   {
      if (obj[_a[0]])
      {
         obj[_a[0]].push(_a[1]);
      } else {
         const newarr = [];
         newarr.push(_a[1]);
         obj[_a[0]] = newarr;
      }
   }  
}

function helper(visited, obj, start, result)
{
    visited.push(start);
    const arr = obj[start];
    if (arr) {
      for(const i of arr)
      {
         if (visited.includes(i)) { continue;}
         helper(visited, obj, i, result);
      }
    }
    result.push(start);
}

