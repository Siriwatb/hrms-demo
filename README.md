# hrms-demo

This project is a demo for a .NET 8 API. It is designed to practice Clean Architecture Design and uses the CQRS pattern with MediatR.

## Features

- **.NET 8 API**: Built with the latest version of .NET.
- **Clean Architecture**: Follows the principles of Clean Architecture to ensure a maintainable and scalable codebase.
- **CQRS Pattern**: Implements the Command Query Responsibility Segregation (CQRS) pattern to separate read and write operations.
- **MediatR**: Utilizes MediatR for handling requests and notifications in a decoupled manner.

## Overview

This project is for managing employee data below.

| EMPNO | FIRST_NAME | LAST_NAME  | DESIGNATION         | HIREDATE    | SALARY | COMM | DEPTNO |
|-------|------------|------------|---------------------|-------------|--------|------|--------|
| 1001  | STEFAN     | SALVATORE  | BUSINESS ANALYST    | 17-NOV-97   | 50000  | -    | 40     |
| 1002  | DIANA      | LORRENCE   | TECHNICAL ARCHITECT | 01-MAY-00   | 70000  | -    | 10     |
| 1003  | JAMES      | MADISON    | MANAGER             | 19-JUN-88   | 80400  | -    | 40     |
| 1005  | LUCY       | GELLER     | HR ASSOCIATE        | 13-JUL-08   | 35000  | 200  | 30     |
| 1006  | ISAAC      | STEFAN     | TRAINEE             | 13-DEC-15   | 20000  | -    | 40     |
| 1007  | JOHN       | SMITH      | CLERK               | 17-DEC-05   | 12000  | -    | 10     |
| 1008  | NANCY      | GILBERT    | SALESMAN            | 20-FEB-81   | 1600  | 300 | 10     |
| 1004  | JONES      | NICK       | HR ANALYST          | 02-JAN-03   | 47000  | -    | 30     |




## Getting Started

To get started with this project, follow these steps:

1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/hrms-demo.git
    ```
2. Navigate to the project directory:
    ```sh
    cd hrms-demo
    ```
3. Build the project:
    ```sh
    dotnet build
    ```
4. Run the project:
    ```sh
    dotnet run
    ```

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

## License

This