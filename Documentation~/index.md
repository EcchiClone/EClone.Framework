# EClone Framework Documentation

EClone Framework는 Unity 프로젝트에서 재사용할 수 있는 공통 매니저/유틸리티 모듈입니다.

## 네임스페이스
- `EClone.Core` : 핵심 매니저 (예: GameManager)
- `EClone.Utils` : 유틸리티 (예: Logger)
- `EClone.Editor` : 에디터 확장 (예: InfoWindow)

## 시작하기
```csharp
using EClone.Core;
using EClone.Utils;

public class Example : MonoBehaviour
{
    void Start()
    {
        GameManager.Instance.Init();
        Logger.Log("Hello EClone Framework!");
    }
}
```

## Samples
- Package Manager → EClone Framework → Samples → Import 버튼 클릭
- `BasicUsage` 씬을 실행