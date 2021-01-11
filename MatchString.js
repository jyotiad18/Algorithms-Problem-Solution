function match(str1, str2)
{
   const s1Len = str1.length;
   const s2 = str2[0];
   const s2Len = str2.length;
   if (s1Len < s2Len) return false;
   let i =  -1;  
   const a = [];
   while((i=str1.indexOf(s2,i+1)) >= 0)
   {      
      const remainLen = s1Len - i;      
      if (remainLen >= s2Len) {
        const nStr = str1.substring(i, i + s2Len)
        if (str2 === nStr) {
          return true;
        }
      }
   }   
   return false;
}


console.log(match("aefoaefcdaefcdaed", "aefcdaed")); // true
console.log(match("adafccfefbbbfeeccbcfd", "ecb")); //false;
console.log(match("aefoaefcdaefcdaed", "aefcaefaeiaefcd")); // true