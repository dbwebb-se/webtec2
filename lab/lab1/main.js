/**
 * This is the main file that executes all test cases to assert that the
 * functions in the module.js are implemented as expected.
 */
import * as lab from './lab.js'
import * as module from './module.js'

console.log('Ready to go to work! Lets make it all green!\n' + '='.repeat(50))
console.log(lab.assert(module.hello, 'Hello world', [], 0))

console.log(lab.assert(module.magicNumber, 42, []))

console.log(lab.assert(module.compare, true, [50]))
console.log(lab.assert(module.compare, false, [40]))
console.log(lab.assert(module.compare, 0, [42]))

console.log(lab.assert(module.celsiusToFahrenheit, 32, [0]))
console.log(lab.assert(module.celsiusToFahrenheit, 68, [20]))
console.log(lab.assert(module.celsiusToFahrenheit, -4, [-20]))

console.log(lab.assert(module.sumToN, 1, [1]))
console.log(lab.assert(module.sumToN, 3, [2]))
console.log(lab.assert(module.sumToN, 10, [4]))

console.log(lab.assert(module.isOdd, true, [1]))
console.log(lab.assert(module.isOdd, false, [42]))

console.log(lab.assert(module.sum, 6, [[1, 2, 3]]))
console.log(lab.assert(module.sum, 1, [[1]]))
console.log(lab.assert(module.sum, 0, [[]]))

console.log(lab.assert(module.max, 6, [[1, 2, 3, 6, 5, 4]], 2))
console.log(lab.assert(module.max, 1, [[1, -1]]))
console.log(lab.assert(module.max, 10, [[10, 9, 8, -10]]))

console.log(lab.assert(module.reverseString, 'cba', ['abc']))
console.log(lab.assert(module.reverseString, 'leakiM', ['Mikael']))

console.log(lab.assert(module.countWords, 4, ['Mumintrollet bor i skogen.'], 2))
console.log(lab.assert(module.countWords, 4, [' Hej jag heter Mikael ']))

console.log(lab.assert(module.countVowels, 9, ['aeiouyåäö.'], 2))
console.log(lab.assert(module.countVowels, 8, ['Mumintrollet bor i skogen.']))

console.log(lab.assert(module.isPalindrom, true, ['AbccbA'], 3))
console.log(lab.assert(module.isPalindrom, true, ['AbcbA']))
console.log(lab.assert(module.isPalindrom, false, ['Mumintroll']))

console.log(lab.done())