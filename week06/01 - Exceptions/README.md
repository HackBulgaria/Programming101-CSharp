### Implement a XmlMarkupBuilder class ###
Make an easy to use XmlMarkupBuilder class, which creates a **valid xml** 

We won't worry about namespaces here. By valid, I mean having the `<?xml version="1.0" encoding="UTF-8"?>` declaration, and having only tags, attributes, and text between a tag opening and tag closing.

For instance:
```
<elements>
	<element attr="attributeValue">attr</element>
</elements>

<!-- valid xml! -->

<elements> Hey dude check it out
	<element> why are you out of scope, man? </element>
</elements>
<!-- Because I am an invalid xml declaration, that is why! -->
```

Your class should support these operations:
```CSharp
XmlMarkupBuilder openTag(String tagName); 
XmlMarkupBuilder addAttr(String attrName, String attrValue); // valid only when you have a tag opened!
XmlMarkupBuilder addText(String text); 
XmlMarkupBuilder closeTag(); //close the last opened tag.
XmlMarkupBuilder finish(); //close all tags and finelize your object. Any open,addAttr or other calls to your object, should throw an Exception.
String getResult(); //let's stay close to http://en.wikipedia.org/wiki/Builder_pattern 
```

Example usages of your `XmlMarkupBuilder` class
```CSharp
XmlMarkupBuilder markupBuilder = new XmlMarkupBuilder();

//http://en.wikipedia.org/wiki/Fluent_interface ftw
String validMarkup = markupBuilder.openTag("body").addAttr("background","0xFF0000").addText("Helo HTML!").finalize().getResult(); 
markupBuilder.closeTag() //BOOOM! Object finalized! Exception!
...............
XmlMarkupBuilder markupBuilder = new XmlMarkupBuilder();
markupBuilder.openTag("a").closeTag().openTag("a") //BOOOM! You need to have a root XML object, XML is not a list!
............... 
XmlMarkupBuilder markupBuilder = new XmlMarkupBuilder();
markupBuilder.openTag("a").closeTag().closeTag() //BOOOM! What the hell are we closing?!
...............
XmlMarkupBuilder markupBuilder = new XmlMarkupBuilder();
markupBuilder.openTag("a").closeTag().addAttribute("href","https://www.youtube.com/watch?v=P5ft_7Bcyc4") //BOOOM! What are you adding attribute to?

and so on and so on
```