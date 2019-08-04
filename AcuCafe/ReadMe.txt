AcuCafe has an ordering system which is poorly designed and sometime fails to deliver the right orders. For example, some of the clients complaint that their ice tea had milk in it. Also, the system turned out to be a maintenance nightmare as it is difficult to add new drinks.

AcuCafe has selected you to update their ordering system to be able to:
-	Stop the preparation of an ice tea with milk and inform the barista
-	Add a new chocolate topping to the expresso
Can you think of any new requirements that can impact your design?

Ensure you commit the completed code into GitHub and send us a link to a public repository. Please register a GitHub account if you don't already have one.
Hints:
We are looking for a solution that shows a good understanding of the SOLID principles, object oriented programming and that displays a working knowledge of TDD.
Please add some commentary to justify the decisions you've taken, if possible by quoting books, blog posts or talks that have influenced you.

-- Stallone Commnents --

I have used the "Factory Design Pattern" and the "Decorator Design Pattern" to upgrade the current application.
I have also listed all the available drinks and their condiments in the app.cofig file and is loaded at start up.
This helps the user to choose the exact type of drink reuired and thus removes the issue of Ice Tea being created with Milk.
I have also made use of the Decorator design patter by which fulfilling the requirement to add chocolate to Expresso.
The decorator pattern can now be used by any new Coffee that the barista decides to bring on. We can noe add and remove the condiments very easily.

The only concern i have is by using the factory design pattern the developwer has to ensure that the factory class is updated everytime a new coffee or drink is made available.
And also needs to make sure that the factory is set to use the correct decorators such as Milk, Sugar, Chocolate etc. 
If a second round of refactoring was to be made then I would like to use the Dependency Injection and dynamically create those factories at run time instead of manually craeting the factories.

-**** References ****-
https://www.c-sharpcorner.com/article/factory-method-design-pattern-in-c-sharp/
https://iamtimcorey.com/interfaces/
https://iamtimcorey.com/design-patterns-dip/
https://code-maze.com/decorator-design-pattern/