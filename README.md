# \OCRecognizer

## Summary

It is a simple project to help us to extract the text from an image using known components

<sup>
    * The real reason for this project is to aggregate knowledge about image processing.
</sup>

## Nice to have

* [.NET Core 3.1] - SDK/RunTime Microsoft .NET Core 3.1 <https://dotnet.microsoft.com/download/dotnet-core/3.1>

* (Optional) [Visual Studio] - Microsoft Visual Studio or another tool.

Application
1. Console Application (Console/Prompt)

- - - -

### 1. CONSOLE APPLICATION - Steps

#### **Using Visual Studio Solution**

1) Open solution file [...src\OCRecognizer.sln] in your Visual Studio
2) Set the project [Presentation/OCRecognizer.Presentation.Console] as StartUp Project
3) Press play button (This action should restore the Nuget Packages during the first build)

### **Where is it getting the image data?**

> The image Every data is coming from the local image [Presentation/OCRecognizer.Presentation.Console/Image]

### **What is the base tech involved?**

* User Terminal: Console Application
* Project Tiers: Class Library
* Dependency: Tesseract OCR [https://github.com/tesseract-ocr/tesseract]

**Base Design Code:**
>Presentation

* Console: It is a layer that contains an user interface to input data and see the results

>Domain

* Services: Domain is a global tier used by all tiers providing the main entities and services

**Packages:**

* TessertactOCR

- - - -

**TODO (BackEnd):**

* Make the image dynamic and comming from web

- - - -

License

** Free by Andre Raiça Silva :sunglasses:
