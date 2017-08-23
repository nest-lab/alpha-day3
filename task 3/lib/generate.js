const checkWord = require('check-word');
const words = checkWord('en'); // setup the language for check, default is en

function generateAnagrams(word) {
  if(word.length >= 8){
    console.warn("WARNING WARNING WARNING! You about to fry your system")
  }  
  if (word.length < 2) {

      return [word];

  } else {
    // By declaring all variables outside of the loop,
    // we improve efficiency, avoiding the needless
    // declarations each time.
    var anagrams = [];
    var before, focus, after;
    var shortWord, subAnagrams, newEntry;

    for (var i = 0; i < word.length; i++) {

        before = word.slice(0, i);
        focus = word[i];
        after = word.slice(i + 1, word.length + 1);
        shortWord = before + after;
        subAnagrams = generateAnagrams(shortWord);
        for (var j = 0; j < subAnagrams.length; j++){
            newEntry = focus + subAnagrams[j];
            anagrams.push(newEntry);
        }
    }
    return anagrams;
  }

}
  
const getValidWords = (wordCombinations=[])=>{
  var validWord = [];

  for(let i=0; i<wordCombinations.length; i++){
    if(words.check(wordCombinations[i])){
      validWord.push(wordCombinations[i]);
      continue;  
    }
  }
  return validWord;
}

const generateValidWord = (word)=>{
  const wordCombinations = generateAnagrams(word);
  return getValidWords(wordCombinations);
}

module.exports = generateValidWord;