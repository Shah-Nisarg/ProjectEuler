function log(msg) {
  document.write(msg + '<br>');
}

// size: number of routes
var cache = {};
function getGridPaths(size, x, y) {
  if (!cache[x]) cache[x] = [];
  if (!cache[x + 1]) cache[x + 1] = [];
  
  if (cache[x][y]) {
    return cache[x][y];
  } else if (size == x && size == y) {
    return 1;
  } else if (size == x) {
    return getGridPaths(size, x, y + 1);
  } else if (size == y) {
    return getGridPaths(size, x + 1, y);
  } else {
    var right = getGridPaths(size, x + 1, y);
    var left = getGridPaths(size, x, y + 1);
    cache[x + 1][y] = right;
    cache[x][y + 1] = left;
    
    return left + right;
  }
}

// x and y are from 0 to 20: 21 points for 20 cells.
log('Start ' + new Date());
try {
  log(getGridPaths(20,0,0));
} catch (e) {
  log('Error: '+ e.toString());
}
log('End ' + new Date());