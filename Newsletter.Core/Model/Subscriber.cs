using System;

namespace Newsletter.Core.Model;

public sealed record Subscriber
(
    string Name,
    string Email
);
