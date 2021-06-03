CREATE DATABASE dbtarefa
USE dbtarefa
	
CREATE TABLE Agenda(
	cpf VARCHAR(11) PRIMARY KEY,
	telefone numeric(9,0),	
	)

CREATE TABLE Cliente(
	idCliente NUMERIC PRIMARY KEY,
	cpfCliente VARCHAR(11)  not null,
	nomeCliente VARCHAR(50) not null,	
	endereco VARCHAR(40),
	banco VARCHAR(15) not null,
	agencia VARCHAR(2) not null,
	contaCorrente VARCHAR(5) not null,
	pix VARCHAR(20)
	)

ALTER TABLE Cliente ADD CONSTRAINT FK_Cliente_Agenda
	FOREIGN KEY  (cpfCliente)
	REFERENCES Agenda(cpf)

INSERT INTO Agenda (cpf, telefone) VALUES ('09328793','928374582')
INSERT INTO Cliente (idCliente, cpfCliente, nomeCliente, endereco, banco, agencia, contaCorrente, pix) VALUES (1, '09328793','Jaqueline Teixeira', 'R. Joao, São Paulo', 'Itau', '30', '92838', '92282931')
INSERT INTO Agenda (cpf, telefone) VALUES ('19812712','937180374')
INSERT INTO Cliente (idCliente, cpfCliente, nomeCliente, endereco, banco, agencia, contaCorrente, pix) VALUES (2, '19812712','Emerson Timoteo', 'R. Jose, São Paulo', 'Itau', '23', '12983', '10912922')
INSERT INTO Agenda (cpf, telefone) VALUES ('20392033','918264096')
INSERT INTO Cliente (idCliente, cpfCliente, nomeCliente, endereco, banco, agencia, contaCorrente, pix) VALUES (3, '20392033','Marcones Nazario', 'R. Maria, São Paulo', 'Itau', '83', '29329', '49857223')
INSERT INTO Agenda (cpf, telefone) VALUES ('23278372','992837510')
INSERT INTO Cliente (idCliente, cpfCliente, nomeCliente, endereco, banco, agencia, contaCorrente, pix) VALUES (4, '23278372','Livia Monteiro', 'R. Jose, São Paulo', 'Itau', '23', '23283', '23293238')
INSERT INTO Agenda (cpf, telefone) VALUES ('23828372','912740988')
INSERT INTO Cliente (idCliente, cpfCliente, nomeCliente, endereco, banco, agencia, contaCorrente, pix) VALUES (5, '23828372','Mauricio Gallo', 'R. Maria, São Paulo', 'Itau', '83', '23728', '29382361')
INSERT INTO Agenda (cpf, telefone) VALUES ('32873287','977283098')
INSERT INTO Cliente (idCliente, cpfCliente, nomeCliente, endereco, banco, agencia, contaCorrente, pix) VALUES (6, '32873287','Andre Lopez', 'R. Ana, São Paulo', 'Itau', '83', '29383', '92837397')

CREATE VIEW AgendaClienteVW AS
SELECT
	nomeCliente AS 'Cliente',
	cpfCliente AS 'CPF',
	endereco AS 'Endereço',
	banco AS 'Banco',
	agencia AS 'AgênciAS',
	cONtaCorrente AS 'CONta Corrente',
	pix AS 'PIX'

FROM Cliente inner join Agenda ON Cliente.cpfCliente=Agenda.cpf

SELECT* FROM AgendaClienteVW

SELECT cpfCliente FROM Cliente
uniON all
SELECT cpf FROM Agenda

SELECT * FROM Cliente AS c inner join Agenda AS a ON c.cpfCliente=a.cpf