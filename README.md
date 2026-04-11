# (C# 코딩) 버거 키오스크

## 개요
- C# 프로그래밍 학습: Windows Forms 환경에서 이벤트 기반 프로그래밍 기초 습득
- 핵심기능: 
    - 라디오 버튼과 체크박스를 이용한 메뉴 선택 및 금액 계산
    - 메뉴 미선택 시 Label을 이용한 에러 메시지 출력 기능
    - 리스트박스를 활용한 주문 내역 실시간 표시
    - 천 단위 콤마(,) 및 상황별 글자색 변경(성공:파랑, 에러:빨강)
- 화면구성: 메뉴 선택 영역, 추가 옵션 영역, 주문 내역(ListBox), 결과 출력(Label), 제어 버튼(주문/초기화)

## 실행 화면
- 1단계 코드의 실행 스크린샷
<img width="952" height="560" alt="1스크린" src="https://github.com/user-attachments/assets/33604c7c-e559-46d8-8908-2ad500d866bf" />

- 2단계 코드의 실행 스크너샷
<img width="970" height="565" alt="2스크린 1" src="https://github.com/user-attachments/assets/b1a91ccb-7798-4cf0-a0ab-a7f5baf530b7" />

<img width="967" height="566" alt="2스크린 2" src="https://github.com/user-attachments/assets/fdbacd8e-12c7-407c-89b2-71ec866181f2" />


## 배운 내용
- if-else 조건문과 부정 연산자(!)를 활용하여 필수 항목 선택 여부를 검증하는 유효성 검사 로직을 익혔습니다.
- 상황에 따라 컨트롤의 속성(ForeColor, Text)을 동적으로 변경하여 사용자에게 직관적인 피드백을 주는 UX 디자인을 경험했습니다.

# (C# 코딩) 버거 키오스크

## 개요
- C# 프로그래밍 학습
- 1줄 소개: 사용자 맞춤형 메뉴 선택과 실시간 금액 계산이 가능한 윈도우 폼 키오스크 프로그램
- 사용한 플랫폼: C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤: RadioButton(메인메뉴), CheckBox(옵션), ListBox(내역), Label(금액/에러), Button
- 사용한 기술과 구현한 기능:
    - 유효성 검사: 메뉴 미선택 시 `return`을 사용하여 실행을 중단하고 경고 문구 출력
    - UI 피드백: 정상 주문 시 파란색, 에러 발생 시 빨간색으로 라벨 색상 제어
    - 데이터 포맷팅: 화폐 단위 표시를 위한 천 단위 구분 기호 적용
    - 초기화 로직: 모든 선택 사항과 UI 상태를 초기값으로 되돌리는 기능 구현

## 실행전 디자인화면 
(img/screenshot-3.1.png)

## 실행 화면
<img width="952" height="560" alt="1스크린" src="https://github.com/user-attachments/assets/b93e69f5-a25b-4690-9278-2ecd35541577" />

- 구현한 내용
1. UI 구성
▶ RadioButton과 CheckBox 등을 적절히 배치합니다.
▶ GroupBox로 적절하게 그룹으로 묶습니다.
2. 주문하기 버튼과 초기화 버튼의 기능 구현
▶ 주문 내역과 총 금액을 표시합니다. 
▶ 다시 주문할 수 있도록 초기화 합니다.

## 실행 화면
<img width="970" height="565" alt="2스크린 1" src="https://github.com/user-attachments/assets/c6af6d91-9ee6-41c0-a1bb-0e37c098e86c" />

<img width="967" height="566" alt="2스크린 2" src="https://github.com/user-attachments/assets/43dc5617-be77-4e30-b15d-93465c7290fd" />

- 구현한 내용
▶실행창에 들어가면 아무것도 선택 안되게 하기
▶아무것도 선택하지 않고 주문하기 버튼을 누르면 에러 메시지 표시
