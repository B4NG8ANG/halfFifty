# halfFifty
2023 동양미래대학교 3학년 졸업작품



## 프로젝트 소개
Unity 및 C#으로 제작한 2D 오픈 월드형 생존 RPG 게임입니다.

![3](https://github.com/B4NG8ANG/halfFifty/assets/50348034/f70f0328-1334-4977-9efe-9a2a7ff0ee5e)

![4](https://github.com/B4NG8ANG/halfFifty/assets/50348034/b15993df-5a1c-4e51-a375-e33b93245718)



## 개발 기간
2023.03.01 ~ 2023.07.01 (6개월)



## 개발 멤버
- kakorolling: 메인 기획, 클라이언트 프로그래밍, 아트 제작
- B4NG8ANG: 메인 기획 및 클라이언트 프로그래밍
- givebro: 클라이언트 프로그래밍
- youmjinsub: 클라이언트 프로그래밍
- Hye-won-Han: 아트 제작
- Leeahyun11: 아트 제작



## 개발 환경
- `Unity`
- `C#`
- Cooperation Tool: Git & Github Desktop
- UI & Art Design: Photoshop



## 주요 기능 및 사용 기술
- 캐릭터의 움직임 애니메이션 구현: 캐릭터가 상하좌우로 움직이는 각각의 모션을 이미지로 그려 Unity 에디터에서 애니메이션 클립 제작. 그 후 Animator에서 해당 클립들을 설정한 뒤 각각의 전환을 생성하고, 스크립트에서 애니메이션 상태를 제어하기 위해 int형 Animations Parameter를 설정. 그 뒤 각 전환마다 Conditions 설정으로 파라미터 값의 조건을 설정. 이후 방향키를 입력받아 캐릭터가 움직일 때 animator.SetInteger 함수를 사용하여 각 방향의 움직임에 해당하는 애니메이션 클립 전환 조건을 만족시켜 애니메이션을 재생.
- 타일 맵 구현: Unity Auto Tile을 사용하기 위해 2D Tilemap Editor 패키지와 Unity 2D Extra 패키지를 설치하고 Tile Palette를 생성. 그 후 Tile Palette에 여러 타일을 포함하는 이미지 파일인 타일셋을 생성. 이때 일반 타일 셋이 아닌, 근접한 타일의 종류를 보고 정해둔 규칙에 따라서 다른 스프라이트를 표시하도록 하는 룰 타일을 사용.
- 아이템 클래스 선언: 게임 내 아이템 오브젝트가 가져야 하는 정보들을 해당 클래스의 속성으로 정의.
- 인벤토리: 플레이어가 얻는 아이템들은 모두 배열에 들어가고, 인벤토리를 관리하는 클래스에서 해당 배열에 들어있는 Item 타입의 객체의 게터 메소드를 이용하여 이름, 수량, 이미지 등의 정보를 가져온 뒤 인벤토리 창에 보여주도록 구현.
- 퀵 슬롯:  인벤토리 와는 다르게 항상 게임 화면의 왼쪽 하단에 활성화 상태로 존재. 퀵 슬롯은 스크립트 상에서 인벤토리와 따로 구분되지 않고 인벤토리의 첫 번째 줄로써 취급. 퀵 슬롯에 아이템을 등록 한 뒤 해당 퀵 슬롯의 버튼을 누르면 조건문을 통해 해당 아이템의 종류를 파악 후 만약 도구라면 캐릭터의 손에 해당 도구를 드는 모습을 나타내기 위해 animator.SetInteger 함수를 사용하여 애니메이션 클립 전환 조건을 만족시켜 캐릭터가 손에 도구를 들고 움직이는 애니메이션을 재생.
- 아이템 드래그 이동: 인벤토리와 퀵 슬롯에서 양방향으로 아이템을 드래그하여 위치를 옮길 수 있는 기능을 구현. 아이템을 드래그 시작할 때 해당 아이템의 이름, 수량, 이미지 등의 정보를 저장해 놓고 드래그가 끝날 때 끝나는 위치에 있는 아이템의 정보와 교환한 뒤 해당 슬롯에 아이템이 보이게 구현.
- 제작 시스템: 재료 아이템을 소모하여 새로운 아이템을 제작. 재료 아이템 객체의 삭제는 인벤토리 배열에 들어있는 아이템 객체를 배열에서 제거하는 방법으로 구현. 제작 아이템 객체의 생성은 Item 클래스의 생성자를 이용하여 new 키워드로 새 Item 타입의 객체를 생성 하는 것으로 구현. 생성된 아이템은 인벤토리 배열 안으로 들어감.
- 벌목 시스템: 캐릭터가 손에 도끼 아이템을 들고 있는 상태에서 나무 오브젝트의 근처로 이동해 F키를 누르면 벌목을 하여 나무 도막 아이템을 획득. 캐릭터가 손에 들고 있는 도구의 종류를 변수에 저장 한 뒤 이 변수에 저장된 값을 검사하여 캐릭터가 손에 어떤 도구를 들고 있는지 파악. 도끼를 들고 있는 상태에서 플레이어가 F키를 누르면 캐릭터가 위치한 position의 일정 반경 내의 모든 콜라이더를 배열에 저장. 그리고 배열에서 하나씩 콜라이더를 검사하여 해당 콜라이더를 가진 오브젝트가 나무인지 검사하고 animator.SetInteger 함수를 사용하여 애니메이션 클립 전환 조건을 만족시켜 캐릭터가 벌목을 하는 애니메이션을 재생. 그 후 나무 오브젝트는 Destroy 함수를 사용하여 파괴 시키고, 제작 기능과 같은 방법으로 인벤토리에 나무 도막 아이템을 생성.
- 낚시 시스템: 캐릭터가 손에 낚싯대 아이템을 들고 있는 상태에서 강가나 바다 근처로 이동해 F키를 누르면 낚시를 하여 물고기 아이템을 획득. 벌목 기능과 동일한 방법으로 구현.
