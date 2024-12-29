
Claro! Aqui está o README completo e mais elegante com formatação em Markdown:

markdown
Copiar código
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
Código 200: Lista de produtos retornada com sucesso.
Código 404: Nenhum produto encontrado.
2. GET /products/{id}
Retorna um produto específico pelo id.

Parâmetro:
id (int): Identificador único do produto.
Exemplo de Resposta:
json
Copiar código
{
  "id": 1,
  "name": "Produto A",
  "price": 100.0,
  "description": "Descrição do Produto A"
}
Código 200: Produto encontrado e retornado.
Código 404: Produto não encontrado.
3. POST /products
Adiciona um novo produto ao banco de dados.

Exemplo de Corpo da Requisição:
json
Copiar código
{
  "name": "Produto C",
  "price": 150.0,
  "description": "Descrição do Produto C"
}
Código 201: Produto criado com sucesso.
Código 400: Requisição inválida (ex.: body vazio).
4. PUT /products/{id}
Atualiza os dados de um produto existente.

Parâmetros:
id (int): Identificador único do produto.
Exemplo de Corpo da Requisição:
json
Copiar código
{
  "id": 1,
  "name": "Produto Atualizado",
  "price": 120.0,
  "description": "Descrição Atualizada"
}
Código 200: Produto atualizado com sucesso.
Código 400: ID do body não corresponde ao ID do path.
Código 404: Produto não encontrado.
5. DELETE /products/{id}
Exclui um produto pelo id.

Parâmetro:
id (int): Identificador único do produto.

Código 204: Produto deletado com sucesso (sem conteúdo no corpo da resposta).

Código 404: Produto não encontrado.

🛠️ Configuração do Ambiente
Certifique-se de ter o .NET 6 SDK instalado.

Configure a string de conexão no arquivo appsettings.json para o seu banco de dados MySQL.

json
Copiar código
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=ApiCatalogo;User=root;Password=sua_senha;"
}
Execute os seguintes comandos para criar e aplicar as migrações:

bash
Copiar código
dotnet ef migrations add InitialCreate
dotnet ef database update
🚀 Como Executar
Clone o repositório:
bash
Copiar código
git clone https://github.com/seu-usuario/api-catalogo.git
Navegue até o diretório do projeto:
bash
Copiar código
cd api-catalogo
Execute o projeto:
bash
Copiar código
dotnet run
Acesse a API em:
Swagger UI: https://localhost:5001/swagger
Produtos Endpoint: https://localhost:5001/products
📚 Tecnologias Utilizadas
ASP.NET Core para a API.
Entity Framework Core para mapeamento ORM.
MySQL como banco de dados.
Dependency Injection para a injeção do contexto de banco.
🤝 Contribuições
Contribuições são bem-vindas!
Sinta-se à vontade para abrir issues ou enviar pull requests com melhorias.

📝 Licença
Este projeto está sob a licença MIT. Consulte o arquivo LICENSE para mais detalhes.

💡 Desenvolvido com ❤️ por Pedro Almeida
