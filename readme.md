## Variance
프로그래머가 스스로 결정을 내릴 때 발생할 수 있는 문제

```shell
dotnet new console --use-program-main -n Variance

dotnet new console -n Variance
# See https://aka.ms/new-console-template for more information
```

```shell
dotnet run 1 2 3 4 5 6
# 결과 값
# 분산: 3.5
```

### 비즈니스 전문가 
* 버그 리포트
    * 입력을 하지 않으면 `-0` 이 발생한다.
        ```shell
        dotnet run 
        # 결과 값
        # 분산: -0
        ```

### 개발자 (프로그래머)
* 해당 비즈니스 전문가가 아니기 때문에 `-0` 에 대해서 알지 못 함.
* 해당 내용 추가
    ```
    dotnet run
    # 결과 값
    # 데이터가 입력되지 않았습니다.
    ```

    
### 비즈니스 전문가 
* 버그 리포트
    * 하나만 입력하는 경우, 분산을 계산이 되면 안된다.
        ```shell
        dotnet run 1
        # 결과 값
        # 분산: NaN
        ```

### 개발자 (프로그래머)
* 해당 비즈니스 전문가가 아니기 때문에 `하나만 입력하면 분산을 계산할 수 없음` 을 알지 못 함.
* 해당 내용 추가
    ```shell
    dotnet run 1
    # 결과 값
    # 2개 이상의 데이터를 입력하세요.
    ```