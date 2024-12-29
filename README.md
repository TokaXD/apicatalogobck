
API Catálogo
Esta é uma API simples de catálogo de produtos construída com ASP.NET Core e Entity Framework Core. A API permite realizar operações básicas de CRUD (Create, Read, Update e Delete) para gerenciar produtos em um banco de dados.

Endpoints
Abaixo está a lista de endpoints disponíveis na API e suas respectivas funcionalidades.

1. GET /products
Retorna todos os produtos cadastrados.

Resposta de Sucesso (200): Lista de produtos.
Resposta de Erro (404): Mensagem "Produtos Não Encontrados" (caso não existam produtos).
2. GET /products/{id}
Retorna um produto específico com base no id.

Parâmetro:
id: Identificador único do produto.
Resposta de Sucesso (200): Produto correspondente ao id.
Resposta de Erro (404): Mensagem "Produto Não Encontrado" (caso o produto não exista).
3. POST /products
Adiciona um novo produto ao banco de dados.

Body da Requisição:
json
Copiar código
{
  "name": "Nome do Produto",
  "price": 100.0,
  "description": "Descrição do Produto"
}
Resposta de Sucesso (201): Produto criado, com o cabeçalho Location apontando para o novo recurso.
Resposta de Erro (400): Mensagem de erro (caso o body esteja vazio ou inválido).
4. PUT /products/{id}
Atualiza um produto existente.

Parâmetros:
id: Identificador único do produto.
Body da Requisição:
json
Copiar código
{
  "id": 1,
  "name": "Produto Atualizado",
  "price": 150.0,
  "description": "Nova descrição do produto"
}
Resposta de Sucesso (200): Produto atualizado.
Resposta de Erro (400): Mensagem "O id de alteração do body request deve ser o mesmo do path request!" (caso o id do body não corresponda ao id do path).
Resposta de Erro (404): Mensagem "Produto Não Encontrado".
5. DELETE /products/{id}
Exclui um produto específico.

Parâmetro:
id: Identificador único do produto.
Resposta de Sucesso (204): Produto excluído com sucesso (sem conteúdo no corpo da resposta).
Resposta de Erro (404): Mensagem "Produto não encontrado para deleção!".
Configuração do Ambiente
Certifique-se de ter o .NET 6 SDK instalado.

Configure a string de conexão no arquivo appsettings.json para o seu banco de dados MySQL.

Exemplo:

json
Copiar código
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=ApiCatalogo;User=root;Password=sua_senha;"
}
Execute os comandos de migração para configurar o banco de dados:

bash
Copiar código
dotnet ef migrations add InitialCreate
dotnet ef database update
Tecnologias Utilizadas
ASP.NET Core para a API.
Entity Framework Core para acesso ao banco de dados.
MySQL como banco de dados.
Dependency Injection para a injeção do contexto do banco.
Como Executar
Clone o repositório:
bash
Copiar código
git clone https://github.com/seu-usuario/api-catalogo.git
Acesse o diretório do projeto:
bash
Copiar código
cd api-catalogo
Execute a aplicação:
bash
Copiar código
dotnet run
Acesse a API em https://localhost:5001/products.
Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests com melhorias.

