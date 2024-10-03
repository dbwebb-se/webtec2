import * as module from './module.js'

console.log("Ready to go to work! Lets make it all green!\n" + "=".repeat(50))
console.log(module.test(module.hello, "Hello world", []))

console.log(module.test(module.magicNumber, 42, []))

console.log(module.test(module.compare, true, [50]))
console.log(module.test(module.compare, false, [40]))
console.log(module.test(module.compare, 0, [42]))

console.log(module.test(module.celsiusToFahrenheit, 32, [0]))
console.log(module.test(module.celsiusToFahrenheit, 68, [20]))
console.log(module.test(module.celsiusToFahrenheit, -4, [-20]))

console.log(module.test(module.sumToN, 1, [1]))
console.log(module.test(module.sumToN, 3, [2]))
console.log(module.test(module.sumToN, 10, [4]))

console.log(module.test(module.isOdd, true, [1]))
console.log(module.test(module.isOdd, false, [42]))

console.log(module.test(module.sum, 6, [[1, 2, 3]]))
console.log(module.test(module.sum, 1, [[1]]))
console.log(module.test(module.sum, 0, [[]]))

console.log(module.test(module.max, 6, [[1, 2, 3, 6, 5, 4]]))
console.log(module.test(module.max, 1, [[1, -1]]))
console.log(module.test(module.max, 10, [[10, 9, 8, -10]]))

console.log(module.test(module.reverseString, 'cba', ['abc']))
console.log(module.test(module.reverseString, 'leakiM', ['Mikael']))

console.log(module.test(module.countWords, 4, ['Mumintrollet bor i skogen.']))
console.log(module.test(module.countWords, 4, [' Hej jag heter Mikael ']))

console.log(module.test(module.countVowels, 9, ['aeiouyåäö.']))
console.log(module.test(module.countVowels, 8, ['Mumintrollet bor i skogen.']))

console.log(module.test(module.isPalindrom, true, ['AbccbA']))
console.log(module.test(module.isPalindrom, true, ['AbcbA']))
console.log(module.test(module.isPalindrom, false, ['Mumintroll']))
