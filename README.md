# Blueshift-Application-Problems

## Problem 1

#### Time Spent
~ 40 minutes
- Most of this time was spent making sure that I had covered all bases on the error checking.
- The reason this was pushed with a large timegap is because I had forgotten to commit the last of the changes before writing this markdown

#### Assumptions/Tradeoffs
- Assumption 1: Using a Calculator class was desired by SOLID principles.
- Assumption 2: "Any non-numeric input other than program control text should be ignored" meant requesting the same thing from the user again and doing nothing with their invalid output.
- Assumption 3: "Minimal code changes" meant quite literally as small as possible. 
The reason I used a dictionary instead of something such as a chain of "if" blocks is because this would provide the requested "minimal code changes". 
In order to add a new calculation, simply implement the new function in the Calculator class and then provide it an alias in the calculationModes dictionary and the rest of the code will work for the new function. This removes the need for creating a new if block to handle a new function
The only way I can think that code changes could be minimised further is by using Reflection, but I don't have a lot of experience with that and it would also mean the loss of aliasing, so have refrained from using it here.

## Problem 2

#### Time Spent
~ 10 minutes
- This was extremely straight-forward as there was no interaction from a user perspective, so no need to handle values based on user error.
- The reason this was pushed with a large timegap is because I had forgotten to commit the last of the changes before writing this markdown

#### Assumptions/Tradeoffs
- Assumption 1: The formulae were required to be implemented manually. The first formula could very easily be implemented using LINQ's .Take and .Average.
- Assumption 2: Math.Max is allowed. If it is not, the alternative solution is
```cs
value = value > 0 ? value : 0;
```
- Assumption 3: Since there was no mention of user interaction, defining the variables as literals is acceptable.
- Assumption 4: There is no need for any SOLID code here, since the apparent objective of the problem is to implement the algorithm, which was done in a function. This function is exclusively dependent on its parameters, so can be moved to wherever it is most applicable to be used in accordance with SOLID principles.
- Assumption 5: All values are correct and valid for the data set (eg. p < x.Length). This would be simple to implement a failsafe for, such as using `Math.Min(x.Length, 10)` or similar, however for the sake of this program I assumed completely correct values.
