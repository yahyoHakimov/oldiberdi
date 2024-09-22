# 1. Full name of the project
Ideation, design, development and MVP implementaion of peer-to-peer loan and deb management platform OldiBerdi. 
# 2. Name of the team and used stack of technologies
**Name of the team** - F&G Group. 
**Name of the project** - peer-to-peer loan and deb management platform OldiBerdi
**Stack of technologies :**
  - **Frontend**: Vue.js
  - **Backend**: .NET Core 6
  - **Database**: MySQL or PostgreSQL
  - **Third-Party Services**: MyID (government ID provider), Payment provider (ackquiring)
# 3. Objective of the project
The project is aimed at providing a simple, convenient and affordable tool for accounting debt relations, both for an individual user and in parallel for both sides of a debt transaction. 
Based on these tools, it is possible to maintain healthy social relations (friendship, family, etc.).
Also, one of the social priorities of the project is to increase financial responsibility and literacy of the population by providing access to educational videos.
# 4. Concept of project
A person who wants to account for all their debt obligations will download our application and start entering debt data. This can be done by those who receive loans and those who have lent part of their savings. Further, the application reminds you about paying debts, shows the progress of debt reduction, and the user receives in one place all information about his funds, to whom and how much money he gave, from whom he has certain debts. 

If the parties want to have some form of protection of their interests, then they can use our service as a third party trustee: the lender creates a new operation and indicates the loan recipient. Next, the borrower confirms with an SMS code the fact of receiving the money and after
# 5. Functional requirements

The project involves the implementation of the following functions:
- user registration
- adding a debt or loan
- attaching the counter-party to the loan transaction
- receiving confirmation from the second party
- adding information about payments
- tracking the closing of a debt transaction
- sending a reminder by the lender to the borrower, in case of non-repayment of the debt at the agreed time
- show debt relationships in one dashboard
- send requests for debt
- collection group debt provision and distributed repayment accounting
# 6. Requirements to the structure of the project

The project should have several windows (pages), after passing the registration and authorization procedure. 
The following pages should be provided in the project:
## Main page
The main page acts as a dashboard, which provides aggregated data on all debts and loans (total amount, quantity), as well as a list of outstanding debts and loans with short information on them.
## Debts page
On this page there will be more detailed information on all debts, with a convenient filter and search. 
When you click on each of the debts, detailed information is shown, starting from the date of the first agreement, the lender, the amount of the debt and the closing date, as well as a spike in transactions for this debt. Also, the user can view the percentage of debt closure as a percentage and in absolute value.
Through this window, the client can add a new debt repayment transaction.
## Loans page 
On this page there will be  detailed information on all loans, given to others by this user.
When you click on each of the loans, detailed information is shown, starting from the date of the first agreement, the borrower, the amount of the loan and the closing date, as well as a spike in transactions for this loan. The user can view the percentage of debt closure as a percentage and in absolute value.
Through this window, the client or borrower can add a new debt repayment transaction.
## Transactions
In the first stage, users can add information about transactions related to debt transactions. Also in this section, they can view all transactions in historical order related to various debt obligations (receipt or provision of debt, full or partial closure of debt, etc.).
In the second phase, it is planned to introduce payment modules into the OldiBerdi system. When paying through the system, the transaction data will be automatically added to the selected debt and will be visible on the transaction page.
# 7. Users categories
We have 2 categories of users: lender and borrower. Any user can have 1 or both the roles. They can add new debt/loan operations, add track records on debt operations, where they participate as the side of the contract. 
We have also moderators, which role is solve the disputes and help with the system to the customers. 
Moderator has not acces to edit user personal data, or any type of data of users, but they can stop access to some users, who has done prohibited activities or abused other users rights.
# 8. Scheme of the project 
Our project architecture is illustrated in the UML diagram below:

![Project Scheme](https://github.com/yahyoHakimov/oldiberdi/blob/main/uml-diagrams/UML2.png)
![Project Scheme](https://github.com/yahyoHakimov/oldiberdi/blob/main/uml-diagrams/UML2.png)
# 9. Integreations
The project will be integrated with three third-party services:
1. **Identification service.** As an identification service, integration with My ID is provided, which is by far the most common identification tool with high reliability.
2. **SMS messaging service.** The use of the foreign Twillio service is currently being considered as an SMS sending service, however, in case of poor-quality work with Uzbek numbers during testing, the SMS service provider may be changed towards one of the local content providers.
3. **Payment service.** To implement the functionality of sending payments through the application, integration with the Click payment service is being considered, taking into account revenue-sharing.

# 10. Additional information