Single Responsibility Principle (SRP)

Problem:
Form1.cs was doing too many things at the same time. It was handling the program logic, database connections, printing, and calculating the order total all in one place.

Solution:
The responsibilities were separated into different classes. For example, OrderCalculator handles calculations, SqlOrderRepository handles database operations, and SmtpEmailService handles sending emails. This makes the code easier to understand, maintain, and modify.

Open/Closed Principle (OCP)

Problem:
Whenever a new type of discount was added, the existing if/else statements inside btnCalculate_Click had to be changed. This could make the code harder to maintain and could introduce new errors.

Solution:
An IDiscountStrategy interface was created to handle different discount types. Now, a new discount can be added by creating a new strategy instead of changing the main calculation code. This keeps the existing code stable while allowing new features to be added.

Liskov Substitution Principle (LSP)

Problem:
The FreeShippingDiscount class caused the system to crash because it threw an exception instead of following the expected discount behavior.

Solution:
The discount classes were corrected so that they all follow the same rules defined by the discount strategy. Because of this, any discount strategy can be used without causing the program to break unexpectedly.

Interface Segregation Principle (ISP)

Problem:
Printing and email functions were originally combined into one large service interface. This forced some classes to implement functions they did not actually need.

Solution:
The large interface was divided into smaller interfaces: IEmailService for email-related tasks and IPrinterService for printing tasks. Each class can now use only the functions it actually needs.

Dependency Inversion Principle (DIP)

Problem:
Form1 was directly creating concrete classes such as SqlConnection and SmtpClient. This made testing difficult because the program needed a real database or network connection.

Solution:
The form now depends on interfaces such as IOrderRepository and IEmailService instead of directly depending on specific classes. This makes it easier to replace implementations, such as using a test database or a fake email service during testing.