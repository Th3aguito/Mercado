create database Mercado;
 
create table Usuario
(
Cpf varchar(100),
Nome varchar(100),
Data_Nasc varchar(100),
Funcao varchar(100),
Cargo varchar(100),
Senha varchar(100)
);
 
create table Produtos 
(
Produto int not null primary key,
Descricao varchar(100),
Valor varchar (100)
);
 
insert into Usuario (Cpf, Nome, Data_Nasc, Funcao, Cargo, Senha)
Values
('000.000.000-00','Davi', '30/04/2007', 'Supervisor', 'Supervisor de vendar', '2007'),
('111.111.111-11','Ella', '30/04/2006', ' Supervisor', 'Supervisor de operações', '2005'),
('222.222.222-22','Thiago', '30/04/2006', 'Gerente', 'Gerente geral' , '2777'),
('333.333.333-33','Bia', '30/04/2006', 'Atendente', 'Caixa', '12345');
 

insert into Produtos (Produto, Descricao, Valor)
values 
('4562', 'Leite 1L', '5,25'),
('5789', 'Ovos 12un', '18,00'),
('6542', 'Açúcar 1kg', '4,80'),
('2365', 'Feijão 1kg', '8,10'),
('3214', 'Arroz 2kg', '22,50'),
('7778', 'Farofa', '6,90'),
('6555', 'Café', '22,90'),
('9875', 'Banana ', '5,00'),
('8989', 'Laranja', '4,00'),
('7899', 'Abacaxi', '8,90'),
('6547', 'Melancia', '6,00'),
('2454', 'Doritos', '12,00'),
('1122', 'Chocolate', '7,90'),
('1031', 'Delicias Brownie i Thiagos', '20,00');
 
select * from Usuario;

create table Cupom_Fiscal
(
Id_Nota int primary key not null auto_increment,
Dia_Hora Varchar(30),
Cupom Text
);

select * from produtos where Descricao like "%ovo%";