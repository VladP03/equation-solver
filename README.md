# equation-solver
Generic equation solver that makes it also possible to find the different roots of an equation.

Limitations:

* will not provide correct answers to equations that don't have real solutions. That is because the function parser used in this project cannot evaluate a function with a complex argument.
* will not provide correct answers if there are typos in the function itself. The used parser also does not really indicate when a given string is not a valid function and it proceeds with certain replacements.
* it is generic within computational limits: if the expression is too complex, the algorithm will take a long time to find some results and might crash.
