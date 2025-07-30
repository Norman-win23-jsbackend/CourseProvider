# 📘 CourseProvider

**CourseProvider** is a serverless GraphQL API built with **.NET 8**, **Azure Functions**, and **HotChocolate**.  
It serves as a modular backend system for educational platforms, enabling flexible and structured course data access via GraphQL.

---

## 🚀 Features

- ⚡ Built on **Azure Functions** for scalable, event-driven execution
- 🔎 Fully functional **GraphQL API** using HotChocolate
- 🧪 Integrated with **Banana Cake Pop** playground for GraphQL testing
- 🔌 Configurable via `host.json` and `local.settings.json`
- 🧱 Modular, cloud-ready architecture with extension points for auth, payments, and more

---

## 📁 Project Structure

```

CourseProvider/
├── Program.cs               # Entry point
├── host.json               # Azure Functions host configuration
├── local.settings.json     # Local dev settings (excluded from Git)
├── CourseProvider.csproj   # Project file
├── GraphQL/                # GraphQL schema, resolvers, types
└── Functions/              # Azure Function triggers (HTTP endpoints)

````

---

## 🛠️ Getting Started

### 1. Install Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Azure Functions Core Tools](https://learn.microsoft.com/en-us/azure/azure-functions/functions-run-local)
- (Optional) [Banana Cake Pop](https://chillicream.com/docs/bananacakepop)

### 2. Clone the Repository

```bash
git clone https://github.com/Norman-Deen/CourseProvider.git
cd CourseProvider
````

### 3. Run the API Locally

```bash
func start
```

Access the GraphQL endpoint at:

```
http://localhost:7071/graphql
```

If Banana Cake Pop is configured, it will open automatically in your browser.

---

## ☁️ Azure Integration

This project is fully compatible with Microsoft Azure, leveraging:

* **Azure Functions** for deployment
* Environment-based configuration with `local.settings.json`
* Ready for integration with Azure Key Vault, Cosmos DB, and API Management

---

## 🔐 Security Notes

* Avoid committing secrets or API keys — use environment variables
* Set proper CORS settings before production deployment
* Protect endpoints with auth strategies like JWT or Azure AD (recommended for future versions)

---

## 📄 License

This project was built for professional development and demo purposes.
You are free to explore and extend it under the [MIT License](LICENSE).

---

**Nour Tinawi**

[LinkedIn](https://www.linkedin.com/in/nour-tinawi) • [Portfolio](https://www.pure-art.co) • [GitHub](https://github.com/Norman-Deen)
