
 Brit QA Tech Test

Guidelines 
Build your solution using .NET C# as the programming language. Deliver the solution with the source code hosted as a public Git repo on a source code management platform such as GitHub.
Please provide instructions for running the solution in the README.md, ideally all dependencies are solved by a package manager or are part of the source code. 
Scenario 1 (API)
Test API : https://restful-api.dev/
https://reqres.in/api/users?page=2
1.	Understand the API Documentation: Review the provided API documentation to understand the endpoints, request methods, parameters, and expected responses.
2.	Create Test Cases: Develop a set of test cases to cover various scenarios
3.	Implement the Tests: Create automated tests for PATCH objects/{id} endpoint.
4.	Observations: Document any observations and findings.
5.	CI Pipeline: Implement a simple CI pipeline using GitHub Actions OR describe the steps to implement the pipeline and what it would look like. The pipeline should:
a.	Run the automated tests whenever there is a new commit
b.	Provide feedback on the test results
