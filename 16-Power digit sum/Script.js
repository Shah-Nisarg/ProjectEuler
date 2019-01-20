var log = (msg) => document.write(msg + "<br>");
var safeLengthOfNumber = 10;
var take = (x, n, sk) => {
  // Skips sk characters and takes first n characters after that.
  if (x.length >= sk) {
    x = x.substring(sk);
    
    if (x.length >= n) {
      return x.substring(0, n);
    } else {
      return x; 
    }
  } else {
    return x;
  }
};
var padZeroes = (count) => new Array(count + 1).join("0");
var multiplyBy2 = (x) => {
  x = x.replace(/^0+(\d+)/g, "$1");
  
  // If a number is larger than x digits, break it down into separate parts, multiply them, pass on the carryover, and return the result string by joining them.
  var results = [];
  var iterations = Math.ceil(x.length / safeLengthOfNumber);
  log("Iter: " + iterations);
  
  // Pad zeroes in front to ensure that the length of the number is multiple of the splits we are making.
  if(iterations > 0 && x.length % safeLengthOfNumber != 0) {
    x = padZeroes(safeLengthOfNumber - (x.length % safeLengthOfNumber)) + x;
  }
  
  for (var sk = iterations-1; sk >= 0; sk--) {
    var num = take(x, safeLengthOfNumber, sk*safeLengthOfNumber);
    var multiplication = ((results[sk+1] || 0) + num * 2).toString();
    
    // For last iteration, pass on the carry, if any.
    if (multiplication.length > num.length 
        && iterations > 0) {
      // Add carry to previous number.
      results[sk] = +(results[sk] || 0) + +take(multiplication, 1, 0);
      results[sk + 1] = (num.startsWith("0") ? "0" : "") 
                   // Skip first digit.
                 + (take(multiplication, safeLengthOfNumber, 1)); 
    } else {
      results[sk + 1] = padZeroes(safeLengthOfNumber - multiplication.length) 
                + multiplication; 
    }
  }
  
  return results.join("");
};

// log(take("1234", 2, 0));
// log(take("1234", 2, 2));
// multiplyBy2("1010102012911010101091");
var num = "1";
for (var i = 0; i < 1000; i++) {
  num = multiplyBy2(num);
  
  log("Raw results: " + num.toString());
  log("Estimate: " + Math.pow(2, i+1));
}
log("Result: " + num);

log("Sum of digits: " + num.split("").reduce((a,r) => +a + +r));