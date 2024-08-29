# Inicialização rápida do projeto

De modo á facilitar o teste da aplicação, foi disponibilizado o executável já compilado dentro do repositório.
Mesmo assim, se faz necessária a configuração dos componentes referentes ao banco de dados SQL Server.
<br/>
<br/>
Segue o passo-a-passo da configuração:
<br/>
<br/>

1. Após clonar o repositório, entre na pasta `app` e execute o arquivo `configuration.bat`;
  
    ![image](https://github.com/user-attachments/assets/e9227b57-d665-4a9d-b6f6-8d1b5bfef31d)
  <br/>
  
3. O CLI terá duas opções: 1 para `INSTALL` e 2 para `CLEAN`, cada uma com sua finalidade:
   <br/>
   - ``INSTALL:`` Subirá o SQL Server via Docker e fará a execução dos scripts de install nas tabelas do banco.
   - ``CLEAN:`` Remove o contâiner criado para aplicação do sistema operacional. A imagem do SQL Server continua ativa para construção de futuros contêineres.

   ![image](https://github.com/user-attachments/assets/0e15a256-6308-4106-b8da-ddaec82e7c3e)
  <br/>

4. Após a finalização do script, já é possível executar o projeto. Execute o arquivo chamado ``GerenciadorFrotas.exe``, no mesmo diretório, para iniciar a aplicação;
   <br/>
   
   ![image](https://github.com/user-attachments/assets/5ce755fd-e759-4a33-ba32-d475c62afcb8)

  - Usuário: `admin`
  - Senha: `admin`

  <br/>

4. Tudo pronto para operar.
   <br/>
   
   ![image](https://github.com/user-attachments/assets/d5bd6eba-80ad-41b8-b97d-0911169ad457)

  
