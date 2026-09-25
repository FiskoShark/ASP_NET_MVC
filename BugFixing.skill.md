# SKILL BugFixing

## Purpose

This Skill helps identify, analyze, and fix bugs in the ASP.NET Core MVC project.

It focuses on finding the root cause of a problem, applying the smallest appropriate fix, and verifying that the existing functionality continues to work.

## When to use

Use this Skill when:

- the project does not compile;
- a runtime error occurs;
- an MVC route does not work;
- a Razor view cannot be found;
- form submission does not work;
- model validation behaves incorrectly;
- an API endpoint returns an unexpected result;
- JavaScript `fetch()` requests fail;
- an existing feature stops working after a code change.

## Context

The project is an ASP.NET Core MVC application.

Project structure:

- `Models/` contains application models.
- `Controllers/` contains MVC and API controllers.
- `Views/` contains Razor views.
- `wwwroot/` contains CSS and JavaScript files.
- `.github/copilot-instructions.md` contains general project instructions.

Main project components:

- `UserController` handles the user creation page.
- `OrdersPageController` displays the order creation form.
- `OrdersController` provides the Orders API.
- `UserModel` contains user validation rules.
- `OrderModel` contains order data and validation rules.

## Inputs

The Skill may receive:

- Bug description
- Error message
- Stack trace
- Affected file
- Expected behavior
- Actual behavior
- Steps to reproduce the problem
- Relevant code

## Workflow

### 1. Analyze the problem

Read the error message and identify the affected part of the application.

Do not immediately rewrite the code.

### 2. Locate the source

Check the relevant:

- controller;
- model;
- Razor view;
- JavaScript;
- CSS;
- route;
- API endpoint.

Follow the existing project structure.

### 3. Identify the root cause

Determine why the bug occurs.

Distinguish between:

- syntax or compilation errors;
- routing errors;
- model validation errors;
- runtime errors;
- API errors;
- Razor view errors;
- JavaScript errors;
- incorrect application logic.

### 4. Explain the problem

Before changing the code, explain:

- what is wrong;
- where the problem is;
- why the problem occurs;
- what part of the application is affected.

### 5. Apply a minimal fix

Change only the code necessary to fix the identified problem.

Do not rewrite working code unnecessarily.

Preserve the existing project architecture and behavior.

### 6. Verify the fix

After applying the fix:

- build the project;
- check that there are no compilation errors;
- verify the affected route or endpoint;
- verify the original functionality;
- check that the fix did not introduce unrelated problems.

## Rules

### General Rules

- Prefer simple and minimal fixes.
- Do not rewrite working code without a clear reason.
- Do not introduce unnecessary dependencies.
- Follow the existing project structure.
- Reuse existing models and controllers when appropriate.
- Explain the cause of a bug before proposing a fix.

### MVC Rules

- Keep MVC page logic in MVC controllers.
- Keep Razor views in the `Views/` folder.
- Ensure controller and view names match correctly.
- Check routing when a page returns `404`.

### API Rules

- Keep API logic in `OrdersController`.
- Preserve the existing `/api/orders` route.
- Use the appropriate HTTP method attributes.
- Return appropriate HTTP status codes.
- Validate incoming models using the existing validation rules.

### Validation Rules

Check the existing Data Annotation validation before adding new validation logic.

Do not duplicate validation rules unnecessarily.

### JavaScript Rules

When debugging form submission:

- check `event.preventDefault()`;
- check form field IDs;
- check the JSON object;
- check the `fetch()` URL;
- check the HTTP method;
- check the `Content-Type` header;
- check the API response.

## Existing Patterns

### User Module

`UserController` uses MVC actions to display and process the user creation form.

User validation is implemented with Data Annotations.

### Orders Module

`OrdersPageController` displays the order creation form.

`OrdersController` is an API controller with the following endpoints:

- `GET /api/orders`
- `GET /api/orders/{id}`
- `GET /api/orders/search?title={title}`
- `POST /api/orders`

`OrderModel.totalPrice` is calculated automatically as:

`price * quantity`

Orders are currently stored in an in-memory list.

## Validations

Before considering a bug fixed:

- the project builds without errors;
- the affected functionality works;
- existing routes still work;
- API endpoints still work;
- model validation still works;
- `totalPrice` is calculated correctly;
- no unrelated functionality was changed.

## Output

The Skill should provide:

1. Bug description
2. Root cause
3. Affected file or files
4. Explanation of the problem
5. Minimal fix
6. Verification result

If no bug is found, explicitly state that no problem was found.