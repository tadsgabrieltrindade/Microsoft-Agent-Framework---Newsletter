using System;

namespace Newsletter.Core.Model;

//sealed é uma indica que a classe não pode ser herdada. 
// record é uma classe imutável, ou seja, seus valores não podem ser alterados depois de criados.
public sealed record Article
(
    string Title, 
    string Url, 
    string Content,
    DateTime PublishedAt
);


