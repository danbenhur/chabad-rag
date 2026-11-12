# chabad-rag

RAG assistant over Chabad Chassidus, built in C#/ASP.NET on Azure (Azure OpenAI + AI Search).

Personal source of truth: github.com/danbenhur/dan-context. Build detail stays in THIS repo; only the strategy layer goes there.

## Run
```
cd src/ChabadRag.Api
dotnet run
# GET http://localhost:5xxx/passage
```

## Steps
1. ✅ ASP.NET project, `GET /passage` returns one hardcoded Tanya passage as JSON.
2. ✅ Passage moved to `data/passage.json`; endpoint reads and deserializes it.
3. ⏳ Next.
