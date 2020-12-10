## Descrição do projeto
Projeto desenvolvido para remplementar os endpoints relacionados a personagens da Api oficial da Marvel. Os dados apresentados nessa API não refletem os apresentados na API oficial 

## Pré-requisitos
- Sistema Operacional Windows
- Visual Studio 2019 
- Asp Net Framework Core 3.1
- IIS Express Versão 10

## Como utilizar o projeto
1. Clone o projeto 
2. Abra a pasta local onde o projeto foi salvo
2. Extraia os arquivos packages1.zip e packages2.zip da pasta \Pacotes e cole em C:\Users\<my-user>\.nuget\packages
3. Abra a cli do net core e execute o comando dotnet restore --source C:\Users\<my-user>\.nuget\packages\
4. Para executar a API abra o Visual Studio e compile a aplicação no modo debug com o servidor ISS Express. Será aberta uma página html gerada pelo Swagger onde os endpoints poderão ser testados
5. Para executar os testes unitários será utilizado o XUnit diretamente do Visual Studio na opção "Run Test"
