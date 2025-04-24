# Douglas Automation Framework

A complete BDD test automation framework using **Selenium WebDriver**, **SpecFlow (Reqnroll)**, and **ExtentReports** to test the [Douglas.de](https://www.douglas.de/de) website.

---

## ✅ Tech Stack

- **Language:** C#
- **Automation Tool:** Selenium WebDriver
- **BDD:** Reqnroll (SpecFlow alternative)
- **Test Framework:** NUnit
- **Reporting:** ExtentReports
- **Design Pattern:** Page Object Model (POM)
- **IDE:** Visual Studio 2022
- **Source Control:** Git + GitHub

---

## 🧪 Features Covered

- Navigate to [Douglas.de](https://www.douglas.de/de)
- Accept cookie consent popup (Shadow DOM interaction)
- Click on "PARFUM" category
- Apply multiple filters:
  - Highlights (e.g., Sale)
  - Marke (e.g., Dior)
  - Produktart (e.g., Eau de Parfum)
  - Geschenk fur (e.g., Geburtstag)
  - Fur Wen (e.g., Damen)
- Verify filtered results are displayed

---

## 📁 Folder Structure

```
DouglasAutomation/
├── Drivers/              # WebDriver initialization
├── Features/             # .feature file and its binding
├── Hooks/                # Test setup and teardown
├── Pages/                # POM classes (HomePage, ParfumPage, etc.)
├── Reports/              # ExtentReport config
├── StepDefinition/       # Step definitions
├── Utilities/            # WaitHelper, ConfigReader, ElementHelper
```

---

## 🚀 How to Run

1. **Clone the repo:**

```bash
git clone https://github.com/DharaVirani/douglas-automation-framework.git
```

2. **Open in Visual Studio**

3. **Build Solution** (Ctrl+Shift+B)

4. **Run tests using Test Explorer**

---

## 📸 Reporting

- **Extent Report** is generated after each test run under:
  ```
  ```

\<project\_root>/Reports/ExtentReport.html

```
- It auto-opens after test execution

---

## ✨ Author
**Dhara Virani**  
Automation Test Engineer  
📧 dhara28virani@gmail.com

---

## 📌 Note
- Custom logic implemented for cookie popup inside **Shadow DOM**.
- POM approach is followed strictly for easy maintainability.
- Easily extendable to other sections of Douglas.de.

---

Let me know if you want to include screenshots or test data for demo purposes!

```
