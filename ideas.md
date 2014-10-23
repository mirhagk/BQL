Ideas for future implementation
===

A collection of things that would be neat to support or have. These are in addition to the ideas already mentioned in [http://tech.pro/blog/1917/a-better-query-language-bql-language-specification]()

Compile on save support
---

BQL is similar in concept to Less or TypeScript, and the workflow should be similar as while. It should support compiling on every save, which means compilation must be reasonably quick, and local to the file (or if global, needs to do global work optionally, and cache results)

Visual Studio Integration
---

Other IDEs should ideally be supported as well, but Visual Studio targets a lot of the people who enjoy tight IDE integration.

SSDT Integration
---


Side Effect Detection
---

In order to fully optimize queries, SQL has quite a lot of undefined logic. Things like the order of when a row in an `UPDATE` statement happens are not specified, which allows the database engine to re-order as it sees fit.

This is perfectly fine, and most of the time you don't run into issues since SQL is mostly filled with pure functions. But if your update statement calls a function, or has a subquery that has side effects, or pulls data from the table being updated, then it's undefined what will happen.

Now detecting side effects in a complete way is probably trying to solve the halting problem, but there's no reason why it can't at least detect and warn about several common cases. This way the programmer can be aware of the fact that changing database versions, or caching, or one of a hundred reasons why the query plan may change, may change the behavior of the function.


New Aggregate Functions
---
Since SQL does not comprehend boolean values it has no built in support for very useful aggregate functions like `NONE`, `ANY`, `ALL`. `CONCAT` is another very useful function to have, that is often emulated using various different approaches. The most popular one is:

~~~
DECLARE @Result NVARCHAR(MAX)
SELECT @Result = @Result + ','+ Value
FROM Table
~~~

This relies on undefined behavior. Having an easy to use aggregate for concatenation would be very useful to have.

Having some general aggregate functions would be useful as well. The `FOLDL` and `FOLDR` functions should be sufficient to implement the majority of aggregate logic. 

The easiest way to implement these would require SQL CLR which requires elevated and potentially dangerous security permissions. It can be restricted to `SAFE` permission set, but many DBAs will likely refuse to have any SQL CLR. So this must be a compiler option. Some of these (such as `CONCAT` can be emulated, and so we should look into emulating some of them without SQL CLR).