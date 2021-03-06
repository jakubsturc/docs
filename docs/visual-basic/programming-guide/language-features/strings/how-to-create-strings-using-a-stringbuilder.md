---
title: "How to: Create Strings Using a StringBuilder in Visual Basic"
ms.date: 07/20/2015
helpviewer_keywords: 
  - "StringBuilder class"
  - "strings [Visual Basic], using StringBuilder"
ms.assetid: 9c042880-aa16-432e-9ccb-cd00abda9ae3
---
# How to: Create Strings Using a StringBuilder in Visual Basic
This example constructs a long string from many smaller strings using the <xref:System.Text.StringBuilder> class. The <xref:System.Text.StringBuilder> class is more efficient than the `&=` operator for concatenating many strings.  
  
## Example  
 The following example creates an instance of the <xref:System.Text.StringBuilder> class, appends 1,000 strings to that instance, and then returns its string representation.  
  
 [!code-vb[VbVbalrStrings#70](../../../../visual-basic/language-reference/functions/codesnippet/VisualBasic/how-to-create-strings-using-a-stringbuilder_1.vb)]  
  
## See also
- [Using the StringBuilder Class](../../../../standard/base-types/stringbuilder.md)
- [&= Operator](../../../../visual-basic/language-reference/operators/and-assignment-operator.md)
- [Strings](../../../../visual-basic/programming-guide/language-features/strings/index.md)
- [Creating New Strings](../../../../standard/base-types/creating-new.md)
- [Manipulating Strings](../../../../standard/base-types/manipulating-strings.md)
