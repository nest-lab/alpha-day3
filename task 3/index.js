const generateValidWord = require('./lib/generate');

//USE CASES:
//Warning, do not run more than 8 letters word if you
//don't want to fry your system. 
var good = generateValidWord('good');
var goat = generateValidWord('goat');
var baby = generateValidWord('baby');

console.log(goat);