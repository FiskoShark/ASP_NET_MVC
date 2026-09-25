# Copilot Instructions

This project is an ASP.NET Core MVC application.

## Project Structure

* Models are located in the `Models` folder.
* MVC controllers are located in the `Controllers` folder.
* Razor views are located in the `Views` folder.
* Static files (CSS, JavaScript) are located in `wwwroot`.

## User Module

* `UserController` is used for user creation.
* User validation is implemented with Data Annotations.
* Confirmation page is located in `Views/User/Confirmation.cshtml`.

## Orders Module

* `OrdersPageController` is used to display the order creation form.
* `OrdersController` is an API controller.
* API route: `/api/orders`.

Available endpoints:

* `GET /api/orders`
* `GET /api/orders/{id}`
* `GET /api/orders/search?title={title}`
* `POST /api/orders`

## Validation Rules

* `title` is required.
* `title` length: 3–50 characters.
* `price`: 1–10000.
* `quantity`: 1–100.
* `totalPrice` is calculated automatically as `price * quantity`.

## Coding Style

* Use clear method names.
* Keep controllers simple.
* Use Data Annotations for validation.
* Do not duplicate business logic.
* Keep API logic in API controllers.

## Code Review

When reviewing this project:
- Check the existing code before suggesting changes.
- Look for bugs, missing validation, and incorrect API behavior.
- Verify that the implementation matches the project requirements.
- Do not rewrite working code unnecessarily.
- Explain the problem before suggesting a solution.