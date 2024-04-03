
# Expense Tracker Web App README

ExpenseTracker is a web application designed to help users track their expenses efficiently. Built on .NET 6 with the MVC (Model-View-Controller) architecture, MySQL, Bootstrap, and Syncfusion for the frontend and UI design.Also this application provides a user-friendly interface to manage expenses seamlessly.
## Features

- Expense Tracking: Users can easily log their expenses, categorize them, and add relevant details such as date, amount, and description.
- Category Management: Users can create, edit, and delete expense categories to organize their expenses effectively.
- Data Visualization: The application offers insightful charts and graphs to visualize expense data, enabling users to analyze their spending patterns.
- Responsive Design: Built with Bootstrap and Syncfusion, the application ensures a responsive design that adapts to various screen sizes and devices.
- Dockerization: The application is dockerized for easy deployment and scalability.

## Technologies Used


- .NET 6: The backend logic and API endpoints are developed using .NET 6, providing a robust and scalable foundation.
- MySQL: The database management system stores and manages expense data efficiently.
- Bootstrap: The frontend is designed using Bootstrap, offering a sleek and responsive user interface.
- Syncfusion: Syncfusion components are utilized for enhanced frontend functionality and UI elements.
- Docker: The application is containerized using Docker for simplified deployment and management.
## Setup Instructions
1.Clone the Repository: Start by cloning the ExpenseTracker repository to your local machine.
```
git clone https://github.com/arshiashirzad/ExpenseTracker.git

```
2. Database Configuration: Configure your MySQL database settings in the appsettings.json file.
```json
"ConnectionStrings": {
    "DefaultConnection": "server=127.0.0.1;port=3306;database=TransactionDb;user=MYSQL_USERNAME;password=MYSQL_PASSWORD"
  }
```
3.Mind changing the connection string also in the "Context/MyDbContext.cs" file

```
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;database=TransactionDb;user=YOUR_USERNAME;password=YOUR_PASSWORD",ServerVersion.AutoDetect("server=127.0.0.1;port=3306;database=TransactionDb;user=YOUR_USERNAME;password=YOUR_PASSWORD"));
            }
        }
```
4.Database Migration: Run the database migration to create the necessary tables in your MySQL database.
```
dotnet ef database update
```
5.Build Docker Image: Build the Docker image using the provided Dockerfile.
```
docker build -t expensetracker .
```
6. Run Docker Container: Run the Docker container using the following command:
```
docker run -d -p 8080:80 expensetracker
```
7.Access the Application: Open your web browser and navigate to http://localhost:8080 to access the ExpenseTracker application.
## Demo

![App Demo](/images/Demo.png)


## Usage

- Dashboard: users are presented with a dashboard displaying summary statistics and expense charts.
- Expense Logging: Users can add new expenses by clicking on the "Add Expense" button and filling out the required details.
- Category Management: Users can manage expense categories through the category management interface.
- Data Visualization: Explore expense data through interactive charts and graphs to gain insights into spending habits.




## Support

For any inquiries or issues, please contact arshiashirzad@khu.ac.ir
##
Happy tracking! 📊💰
