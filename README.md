# 🤖 AI Chat Application

A full-stack AI chat application built using **React**, **.NET Web API**, and a **local Large Language Model (LLM)** powered by **Ollama**.

This project demonstrates how to integrate AI capabilities into a modern full-stack application **without relying on paid external AI APIs**.

## 🚀 Features
- 💬 Real-time chat interface
- 🧠 AI responses using a local LLM (Mistral via Ollama)
- ⚙️ Backend API built with .NET
- 🌐 Frontend built with React
- 🔒 No API keys or paid services required
- 📦 Clean and scalable project structure


## 🏗️ Project Structure
ai-chat-application/
│
├── BackEnd/ # .NET Web API
│
├── FrontEnd/ # React Chat UI
│
├── .gitignore
└── README.md

## 🧠 How It Works
      React UI
      ↓
      .NET Web API
      ↓
      Ollama (Local AI Server)
      ↓
      Mistral LLM
  
- React sends the user message to the .NET API
- .NET API calls Ollama running locally
- Ollama processes the request using a local AI model
- The response is sent back to the UI

---------------------------------------

## ▶️ How to Run the Project Locally

### 1️⃣ Install Ollama
Download and install Ollama from: https://ollama.com
Run these commands on your CMD:
Verify installation:
```bash
ollama --version

ollama pull mistral
ollama run mistral

Keep Ollama running in the background.

3️⃣ Run Backend (.NET API)
Open the BackEnd project in Visual Studio
Run the application
Swagger should open automatically
API Endpoint:
POST /api/chat

4️⃣ Run Frontend (React)
cd FrontEnd
npm install
npm start
Frontend URL:    http://localhost:3000

🧪 Example API Request
{
  "message": "Explain async and await in C#"
}

Example Response
{
  "reply": "Async and await in C# are used to perform non-blocking asynchronous operations..."
}

🛠️ Tech Stack
Frontend: React.js
Backend: .NET Web API (C#)
AI Engine: Ollama (Mistral LLM)
Tools: Swagger, Git, GitHub

📌 Why Ollama?
Runs AI models locally
No API keys required
No usage limits
Ideal for learning, demos, and prototypes

🚀 Future Enhancements
Conversation history / memory
Better UI styling
Authentication
Deployment to cloud VM
Switchable AI providers (OpenAI / Azure)

👩‍💻 Author
Anu Yadav
Full Stack .NET Developer
GitHub: https://github.com/anuYadavDotNet
