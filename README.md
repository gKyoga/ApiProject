🚀 API de Cadastro de Usuário - ASP.NET & C#
Bem-vindo ao repositório da API de Cadastro de Usuário! 🎉 Aqui você encontrará uma API RESTful desenvolvida com ASP.NET Core e C# para realizar o cadastro de usuários.

🔧 Tecnologias Utilizadas
ASP.NET Core 🖥️
C# 💻
Entity Framework Core 🗄️
SQL Server 🛢️
Swagger 📝
📦 Funcionalidades
Cadastro de novos usuários 👤
Consulta de usuários 🔍
Atualização de informações de usuários ✏️
Exclusão de usuários ❌
🚀 Como Executar o Projeto
Clone o repositório:

bash
Copiar código
git clone https://github.com/seu-usuario/nome-do-repositorio.git
Navegue até o diretório do projeto:

bash
Copiar código
cd nome-do-repositorio
Configure a string de conexão no arquivo appsettings.json com seu banco de dados SQL Server.

Execute as migrações para criar o banco de dados:

bash
Copiar código
dotnet ef database update
Execute o projeto:

bash
Copiar código
dotnet run

🛠️ Endpoints
POST /api/usuarios - Cadastra um novo usuário.
GET /api/usuarios - Lista todos os usuários.
GET /api/usuarios/{id} - Retorna um usuário pelo ID.
PUT /api/usuarios/{id} - Atualiza um usuário.
DELETE /api/usuarios/{id} - Exclui um usuário.

📜 Licença
Este projeto está sob a licença MIT. Sinta-se à vontade para usá-lo e modificá-lo! 😊