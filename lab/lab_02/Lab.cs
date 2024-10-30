/**
 * This module contains lab specific code to assert the functions of the lab 
 * and to calculate the result.
 */

using System.Collections.Generic;

static class Lab
{
    /**
     * Define the two levels to PASS or PASS W DISTINCTION.
     */
    static int PASS = 12;
    static int PASS_W_HONOUR = 15;

    /**
     * Store the total number of points, when calculated.
     */
    static int TOTAL;

    /**
     * Return a string with motivational feedback.
     * @returns {string} A string with a message.
     */
    static public string Feedback (int points)
    {
        string msg = "Try to earn 1 point to get started... 😏";
        if (points == 1) 
        {
            msg = "Nice work, lets go, do another! 😉";
        }
        else if (points == PASS - 1)
        {
            msg = "Just one more to PASS. Lets go. 😅";
        }
        else if (points == PASS)
        {
            msg = "Excellent, you have PASSED. Lets try one more? 😁";
        }
        else if (points == PASS_W_HONOUR)
        {
            msg = "That is the way, you PASSED WITH HONOUR! 😍";
        }
        else if (points == PASS_W_HONOUR)
        {
            msg = "That is the way, you PASSED WITH HONOUR! 😍";
        }
        else if (points == TOTAL)
        {
            msg = "What can I say. You impress me. 🙌";
        }
        else if (points > 1 && points < 6)
        {
            msg = "Great, you are on fire and progress is made. 😋";
        }
        return msg;
    }



    /**
     * Class to hold statistics summary for each method.
     */
    class Statistic {
        public int run = 0;
        public int passed = 0;
        public int failed = 0;
        public int points;

        public Statistic (int aPoint)
        {
            points = aPoint;
        }

        public void Run (bool success)
        {
            run++;
            if (success) 
            {
                passed++;
            } 
            else
            {
                failed++;
            }
        }
    }

    /**
     * Dictionary to hold statistics of each method call.
     */
    static Dictionary<string, Statistic> stats = new Dictionary<string, Statistic>();

    /**
    * Execute the testcase and assert that it was corrent or not and return a
    * status string the can be written out.
    * @param {Function} func - The function to test.
    * @param {Object} expected - The expected result from the function call.
    * @param {Object} args - The arguments to send to the function.
    * @param {number} point - The number of points that this functions is worth in total.
    * @returns {string} A string representation of the test case success or failure.
    */
    static public string Assert(
        Delegate method,
        object[] args,
        object expected,
        int point = 1
    )
    {
        // Call the method with the arguments
        object? result = method.DynamicInvoke(args);
        bool success = false;

        // Verify that returned result matches the expected
        if (expected == null && result == null)
        {
            success = true;
        }
        else if (expected is not null && result is not null && expected.GetType() == result.GetType())
        {
            if (expected.GetType() == typeof(string) && (string)expected == (string)result)
            {
                success = true;
            }
            else if (expected.GetType() == typeof(int) && (int)expected == (int)result)
            {
                success = true;
            }
            else if (expected.GetType() == typeof(double) && (double)expected == (double)result)
            {
                success = true;
            }
            else if (expected.GetType() == typeof(bool) && (bool)expected == (bool)result)
            {
                success = true;
            }
        }

        // Calculate the stats
        string methodName = method.Method.Name;
        if (stats.ContainsKey(methodName) == false)
        {
            stats.Add(methodName, new Statistic(point));
        }
        stats[methodName].Run(success);

        // Prepare the argument string
        string successStr = success ? "✅" : "❌";
        string argStr = argsAsString(args);
        string expectedStr = expected is not null ? argsAsString([expected]) : "";
        string resultStr = result is not null ? argsAsString([result]) : "";
        string expectedType = expected is not null ? expected.GetType().ToString().Substring(7) : "";
        string resultType = result is not null ? result.GetType().ToString().Substring(7) : "";

        return $"{successStr} {methodName}({argStr}), expected: {expectedStr} ({expectedType}), actual: {resultStr} ({resultType})";
    }



    /**
    * Format a value to its string representation.
    * @param {Object} args - A value to parse and format as a string.
    * @returns {string} A string representation of the value.
    */
    static string argsAsString(object[] args)
    {
        string argStr = "";
        for (int i = 0; i < args.Length; i++)
        {
            if (args[i].GetType() == typeof(string))
            {
                argStr += $"\"{args[i]}\", ";
            }
            // else if (typeof arg === 'object' && Array.isArray(arg)) {
            //     argStr += `[${arg}], `
            // }
            else
            {
                argStr += $"{args[i]}, ";
            }
        }

        return argStr.Length > 2
            ? argStr = argStr.Substring(0, argStr.Length - 2)
            : argStr
        ;
    }



    /**
    * Print out the results when the execution is done.
    * @returns {string} A string representation of the results.
    */
    static public string Done ()
    {
        int points = 0;
        int passed = 0;
        int failed = 0;
        int total = 0;
        int result = 0;
        string str = "";

        foreach (KeyValuePair<string, Statistic> method in stats) 
        {
            points += method.Value.points;
            passed += method.Value.passed;
            failed += method.Value.failed;
            total  += method.Value.passed + method.Value.failed;
            result += method.Value.points * (int) Math.Floor((decimal) method.Value.passed / (method.Value.passed + method.Value.failed));
            //Console.WriteLine($"{points} {passed} {failed} {total} {result}");
        }
        TOTAL = points;

        str += $"Status of test cases: Passed: {passed}, Failed: {failed}, Total: {total}";
        str += $"\nYou need {PASS} points to PASS and {PASS_W_HONOUR} points to PASS WITH HONOUR.";
        str += $"\nYou have {result} points out of total {points} points.";
        str += $"\n{Feedback(result)}";
        return str;
    }
}
