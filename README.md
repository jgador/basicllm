# 🧠 BasicLLM — A Tiny Next-Word Predictor in C#

This is a **very basic C# console application** that simulates how a language model might predict the next word in a sentence based on a simple dictionary of word transitions. It’s **not a real machine learning model**, but it’s a useful learning tool to understand the **core idea** behind how large language models work: predicting the next word given some context.

---

## 📜 What This Project Is

This project is:
- A **toy model** of a language model.
- Based entirely on **hardcoded probabilities** (no training).
- Focused on predicting the **next word** based on the **last word of the input**.
- Aimed at educational purposes only.

---

## 💡 How It Works

When you run the app:

1. You type a phrase, like:
hello

2. The program extracts the **last word** of your phrase (e.g., `"hello"`).

3. It then looks up a predefined list of **next-word probabilities** for `"hello"`:
```csharp
{ "hello", { "world": 0.9, "you": 0.1 } }
```
It chooses the most likely word - in this case, "world" - and prints:
```csharp
Next word might be: world
```