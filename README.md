# Blueshift-Application-Problems

## Problem 1

#### Time Spent
~ 40 minutes
- Most of this time was spent making sure that I had covered all bases on the error checking and also that the "minimal code changes" was performed optimally without excessive complexity (further discussion in Potential Changes section)
- The reason this was pushed with a large timegap is because I had forgotten to commit the last of the changes before writing this markdown

#### Assumptions/Tradeoffs
- Assumption 1: Using a Calculator class was desired by SOLID principles.
- Assumption 2: "Any non-numeric input other than program control text should be ignored" meant requesting the same thing from the user again and doing nothing with their invalid output.
- Assumption 3: "Minimal code changes" meant quite literally as small as possible. 
The reason I used a dictionary instead of something such as a chain of "if" blocks is because this would provide the requested "minimal code changes". 
In order to add a new calculation, simply implement the new function in the Calculator class and then provide it an alias in the calculationModes dictionary and the rest of the code will work for the new function. This removes the need for creating a new if block to handle a new function

#### Potential Changes
There is a lot of variability in this problem depending on the desired complexity and optimisation of the "minimal code changes". For each "tier" (per se) of minimalisation, you lose some level of cleanliness in the code and also increase its complexity beyond what is potentially necessary for the problem. For example, the absolute simplest way of completing this would be something along the lines of the following:
```cs
if (input == "mode1")
  calculator.Mode1(params)
else if (input == "mode2")
  calculator.Mode2(params)
...
```
This would be arguably the simplest to read, but also not ideal for expandability with minimal and modular code changes. The most optimal way that I could reasonably think of without overdoing the complexity was what I implemented, with a HashTable of functions available for the calculator, and this way all operations which validated the user input could be verified against the hash table instead of having a separate code block for each function which would need to be manually programmed. The only way I can think that code changes could be minimised further is by using the Reflection library, but I don't have a lot of experience with that and it would also mean the loss of clean aliasing in the way that hash tables do it, so I have refrained from using it here.

It also depends on how much the space and time complexity is valued. I believe the hash table implementation I have made is potentially one of the most time efficient solutions, but there is certainly an argument for overdoing the space complexity as well, so it all depends on the desired outcome.

In conclusion, there are several possible ways of approaching the modularity of this problem and all of them are simple to do, it just depends on the desired complexity and cleanliness of the code as well as how literally to take "minimal code changes" without compromising those.


## Problem 2

#### Time Spent
~ 10 minutes
- This was extremely straight-forward as there was no interaction from a user perspective, so no need to handle values based on user error.
- The reason this was pushed with a large timegap is because I had forgotten to commit the last of the changes before writing this markdown

#### Assumptions/Tradeoffs
- Assumption 1: The formulae were required to be implemented manually. The first formula could very easily be implemented using LINQ's .Take and .Average.
- Assumption 2: `x = Math.Max(value, 0)` is allowed. If it is not, the alternative solution is
```cs
x = value > 0 ? value : 0;
```
- Assumption 3: Since there was no mention of user interaction, defining the variables as literals is acceptable.
- Assumption 4: There is no need for any SOLID code here, since the apparent objective of the problem is to implement the algorithm, which was done in a function. This function is exclusively dependent on its parameters, so can be moved to wherever it is most applicable to be used in accordance with SOLID principles.
- Assumption 5: All values are correct and valid for the data set (eg. p <= x.Length). This would be simple to implement a failsafe for, such as using `Math.Min(x.Length, 10)` or similar, however for the sake of this program I assumed completely correct values.

#### Potential Changes
The only changes which may be required here are to do with the SOLID principles. As mentioned before, this problem seems to be targetted more at the ability to create an algorithm taking parameters and performing predetermined mathematics based on those parameters, and as such have not specifically aimed to create a "SmoothingFunction" class or something of that nature. If this was required, then that again would be simple to implement. Of course, if assumption 4 was incorrect and there are invalid parameters or parameters that are not correct, this would be trivial to verify. α and p can be compared to bounds in the following way: 
```cs 
// checks if alpha is invalid
if (α < 0 || α > 1) 
  // error
 
// check if p is invalid
if (p > Math.Min(x.Length, 10))
  // error
```
