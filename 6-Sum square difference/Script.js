
function sumOfSquares(n) {
  var sum = 0;
  while (n > 0) {
    sum += n*n;
    n--;
  }
  return sum;
}

function squareOfSum(n) {
  var sum = 0;
  while (n > 0) {
    sum += n;
    n--;
  }
  return sum*sum;
}

var number = 100;
var answer = squareOfSum(number) - sumOfSquares(number);
console.log(answer);