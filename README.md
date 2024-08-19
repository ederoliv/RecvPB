# RecvPB 
## Software desenvolvido em .NET Framework (C# Windows Forms e Access database), co objetivo que suprir uma necessidade específica no recebimento do almoxarifado central da empresa Progás Braesi.

No recebimento de alguns produtos (motores, chicotes elétricos etc) há a necessidade de um controle dos produtos que entram, para fins de auditoria,
de modo que em caso de defeito em algum lote dos produtos, seja possível identificar a data de entrada do lote, o fornecedor e quantos itens desde
lote defeituoso há nas dependências da empresa.

A solução até a data da implantação do software é um formulário criado com o InfoPath (Microsoft Office 2007), que realiza a persistência dos
dados em um arquivo de banco de dados Access (.accdb). Por se tratar de uma ferramenta antiga, o uso da ferramenta impossibilitou a atualização
do sistema operacional para a versão mais recente(Windows 7 PRO para Windows 11 PRO). Para tornar facilitar a migração que já teria como
desafio a mudança da interface gráfica, optei por utilizar o mesmo arquivo de banco de dados, não sendo feita a atualização do banco.


No sistema nós temos que pontuar algumas entidades que são fundamentais para que seja feita o controle de entrada de produtos, são elas:
- [x] Produto 
- [x] Recebedor
- [x] Fornecedor
- [x] Recebimento

### 1 - Tela inicial/Registro de entrada de produtos
![tela-inicial](/Resources/screenshots/tela-inicial.png)

### 2 - Tela de consulta de recebimentos
![consulta-recebimento](/Resources/screenshots/consulta-recebimento.png)

### 3 - Tela de cadastro de fonecedores
![cadastra-fornecedor](/Resources/screenshots/cadastra-fornecedor.png)

### 4 - Tela de cadastro de recebedores
![cadastra-recebedor](/Resources/screenshots/cadastra-recebedor.png)

### 5 - Tela de cadastro de produtos
![cadastra-produto](/Resources/screenshots/cadastra-produto.png)