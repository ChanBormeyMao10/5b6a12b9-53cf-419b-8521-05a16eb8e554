## Problem
Develop a function that takes one string input of any number of integers separated by single whitespace. The function then outputs the longest increasing subsequence (increased by any number) present in that sequence. If more than 1 sequence exists with the longest length, output the earliest one. You may develop supporting functions as many as you find reasonable


## Getting Started

### Support

*This project is built using C# .Net Framework 4.7.2 class library

### SetUp

* Clone From GitHub
```
git clone https://github.com/ChanBormeyMao10/5b6a12b9-53cf-419b-8521-05a16eb8e554.git
```
* Restore Packages 
```
cd K9.MaxAscend
run restore.bat
```

* Build Solution
```
 msbuild K9.MaxAscend\K9.MaxAscend.sln
```
or in Visual Studio
```
Just Build the Solution
```

### Running Test

```
cd K9.MaxAscend\K9.MaxAscend.Test\bin\Debug
dotnet test K9.MaxAscend.Test.dll --filter Name~Test
```
### Code Coverage Report

``` 
cd K9.MaxAscend
```
Run 
```
coverage.bat
```

* See the Report at 
```
cd coverage\K9.MaxAscend_MaxAscend.html
```
![Coverage](https://github-production-user-asset-6210df.s3.amazonaws.com/70845603/303915039-55c2997f-3bcb-4579-a2fc-a534d71f32ba.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAVCODYLSA53PQK4ZA%2F20240211%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20240211T112937Z&X-Amz-Expires=300&X-Amz-Signature=ea1742cdaf0394410865aa18bb52e186ff6aa752a7fa919fca2bf732f1a6e5cb&X-Amz-SignedHeaders=host&actor_id=70845603&key_id=0&repo_id=755492009)
![Result](https://github-production-user-asset-6210df.s3.amazonaws.com/70845603/303915046-a034e596-f44c-4863-90a0-51bf73c867f0.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAVCODYLSA53PQK4ZA%2F20240211%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20240211T113037Z&X-Amz-Expires=300&X-Amz-Signature=68f7f9d16423d4c18566722fd7077f507215c40c83aaa7939eeebdfd8068284e&X-Amz-SignedHeaders=host&actor_id=70845603&key_id=0&repo_id=755492009)