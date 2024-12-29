# 📦 API Catálogo

Uma API simples para gerenciar um catálogo de produtos, construída com **ASP.NET Core** e **Entity Framework Core**. 

---

## 🚀 Funcionalidades
- ✅ Criar novos produtos.
- ✅ Listar todos os produtos.
- ✅ Consultar um produto por ID.
- ✅ Atualizar informações de um produto.
- ✅ Deletar produtos.

---

## 🛠️ Endpoints

### **1. `GET /products`**
Retorna todos os produtos cadastrados.

#### Exemplo de Resposta:
```json
[
  {
    "id": 1,
    "name": "Produto A",
    "price": 100.0,
    "description": "Descrição do Produto A"
  },
  {
    "id": 2,
    "name": "Produto B",
    "price": 200.0,
    "description": "Descrição do Produto B"
  }
]
