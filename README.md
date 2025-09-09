
# LoginAutomation

Automated UI testing project for a sample login page using **Selenium WebDriver** with **C#** and **NUnit**.

---

## 📋 Project Overview

This project showcases a straightforward automated login test built with Selenium WebDriver in C#. It demonstrates:

- Browser automation using ChromeDriver  
- Implementation of the **Page Object Model (POM)** design pattern for maintainable tests  
- Use of the **NUnit** framework for structuring and running test cases  
- Basic validation of successful login by verifying UI elements  

---

## 🛠️ Technologies Used

- **C#** (latest features with .NET 9.0)  
- **Selenium WebDriver** for browser automation  
- **NUnit** testing framework  
- **ChromeDriver** to drive Google Chrome browser  

---

## ⚙️ Prerequisites

Before running the tests, ensure you have the following installed:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)  
- [Google Chrome browser](https://www.google.com/chrome/)  
- Compatible [ChromeDriver](https://sites.google.com/chromium.org/driver/) version matching your Chrome browser  

---

## 🚀 Getting Started

Follow these steps to set up and run the automated tests locally:

1. **Clone the repository:**

   ```bash
   git clone https://github.com/r2dapps/LoginAutomation.git
   cd LoginAutomation
   ````

2. **Restore dependencies:**

   ```bash
   dotnet restore
   ```

3. **Run the test suite:**

   ```bash
   dotnet test
   ```

---

## 🗂️ Project Structure

| File                  | Description                                                                |
| --------------------- | -------------------------------------------------------------------------- |
| `WebDriverFactory.cs` | Initializes and configures Selenium WebDriver instances                    |
| `LoginPage.cs`        | Page Object Model representing the login page UI elements and interactions |
| `LoginTests.cs`       | NUnit test class containing setup, teardown, and login tests               |

---

## 🔍 Sample Test Case: `ValidLoginTest`

This test case:

* Navigates to [Practice Test Login Page](https://practicetestautomation.com/practice-test-login/)
* Enters valid username and password credentials
* Clicks the login button
* Verifies successful login by checking the presence of the **"Log out"** button

---

## 🤝 How to Contribute

Contributions are welcome! Whether it's fixing bugs, improving test coverage, or adding features:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/your-feature`)
3. Commit your changes (`git commit -m 'Add some feature'`)
4. Push to your branch (`git push origin feature/your-feature`)
5. Open a Pull Request

Please ensure your code follows existing style and includes relevant tests.

---

## 📄 License

This project is licensed under the **MIT License**. See the [LICENSE](LICENSE) file for details.

---

## 📫 Contact

Developed and maintained by **R2DApps**
GitHub: [https://github.com/r2dapps](https://github.com/r2dapps)

---

Thank you for checking out this project! Feel free to reach out if you have any questions or suggestions.

```

---

Just save this as `README.md` in your repo root, and it’s ready to go. If you want, I can help add badges or images next!
```

