<Query Kind="Statements" />

// Equals for value types
var int1 = 123;
var int2 = 123;

(int1 == int2).Dump("Comparing two valuess");

//((object)int1 == (object)int2).Dump("Comparing the references");