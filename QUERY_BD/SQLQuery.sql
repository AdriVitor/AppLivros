CREATE DATABASE Biblioteca;

DROP TABLE Livros;
CREATE TABLE Livros(
	Id INT NOT NULL IDENTITY(1,1),
	Titulo NVARCHAR(110) NOT NULL,
	Genero NVARCHAR(40) NOT NULL,
    Dt_Lancamento DATE,

	 PRIMARY KEY(Id)
);

INSERT INTO Livros(Titulo,Genero,Dt_Lancamento) VALUES('Romeu e Julieta','Romance','1616/12/12');
INSERT INTO Livros(Titulo,Genero,Dt_Lancamento) VALUES('O Quinze','Romance','1930/01/06');
INSERT INTO Livros(Titulo,Genero,Dt_Lancamento) VALUES('Auto da Barca do Inferno','Drama','1517/05/04');

