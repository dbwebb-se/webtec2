/**
 * This module contains lab specific code to assert the functions of the lab
 * and to calculate the result.
 */

/**
 * Execute the testcase and assert that it was corrent or not and return a
 * status string the can be written out.
 * @param {Function} func - The function to test.
 * @param {Function} expected - The expected result from the function call.
 * @param {Function} args - The arguments to send to the function.
 * @returns {string} A string representation of the test case success or failure.
 */
export function assert (func, expected, args) {
  const result = func(...args)
  const success = expected === result ? '✅' : '❌'
  // check if array []
  // print as string ''
  // print out the arguments used in each testcase
  // calculate the points
  return `${success} [${func.name}] ${expected} (${typeof expected}) => ${result} (${typeof result})`
}
