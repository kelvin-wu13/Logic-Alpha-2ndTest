## Breakdown Feature:

<table>
  <tr>
    <th>Scene Name</th>
    <th>Description</th>
    <th>Picture</th>
  </tr>
  <tr>
    <td>Main Menu</td>
    <td>Menu awal dari game memunculkan 3 opsi Level: Level 1, Level 2, Level 3.</td>
    <td><img width="100%" src="https://github.com/kelvin-wu13/Logic-Alpha-2ndTest/blob/main/Gambar/Screenshot%202024-12-04%20230804.png"></td>
  </tr>
  <tr>
    <td>Level 1 - Level 3</td>
    <td>Scene yang menampilkan game dari 2D SpaceShooter.Di scene ini pemain akan mengendalikan Spaceship untuk menembak spaceship lawan.Musuh yang berhasil tertembak akan drop coin dan heart item jika health player di bawah dar 3.</td>
    <td><img width="100%" src="https://github.com/kelvin-wu13/Logic-Alpha-2ndTest/blob/main/Gambar/Screenshot%202024-12-04%20230723.png"></td>
  </tr>
</table>

## Scene Flow
<td><img width="100%" src="https://github.com/kelvin-wu13/Logic-Alpha-2ndTest/blob/main/Gambar/SceneFlow.png"></td>

## Module List
<table>
  <tr>
    <th>Script Name</th>
    <th>Scene</th>
    <th>Responsibility</th>
  </tr>
  <tr>
    <td>Main Menu</td>
    <td><a href = "https://github.com/kelvin-wu13/Logic-Alpha-2ndTest/blob/main/Assets/Scenes/MainMenu.unity"> MainMenu.</a></td>
    <td>-Show main menu UI,Load Level scene when player click the button,Exit Game when player click Quit.</td>
  </tr>
  <tr>
    <td>BackgroundScrolling</td>
    <td><a href = "https://github.com/kelvin-wu13/Logic-Alpha-2ndTest/blob/main/Assets/Scenes/Level%201.unity"> Level 1 - Level 3.</a><a href = "https://github.com/kelvin-wu13/Logic-Alpha-2ndTest/blob/main/Assets/Scenes/MainMenu.unity"> MainMenu.</td>
    <td>-Make the Background scroll</td>
  </tr>
      <tr>
    <td>PlayerController</td>
    <td><a href = "https://github.com/kelvin-wu13/Logic-Alpha-2ndTest/blob/main/Assets/Scenes/Level%201.unity"> Level 1 - Level 3.</a></td>
    <td>-Move Player,Shoot Bullet,Handle PlayerDamage.</td>
  </tr>
      <tr>
    <td>EnemyShip</td>
    <td><a href = "https://github.com/kelvin-wu13/Logic-Alpha-2ndTest/blob/main/Assets/Scenes/Level%201.unity"> Level 1 - Level 3.</a></td>
    <td>-Handle EnemyDamage,Auto Shoot Bullet,Enemy Move Down.</td>
  </tr>
      <tr>
    <td>EnemySpawner</td>
    <td><a href = "https://github.com/kelvin-wu13/Logic-Alpha-2ndTest/blob/main/Assets/Scenes/Level%201.unity"> Level 1 - Level 3.</a></td>
    <td>-Spawn Enemy.</td>
  </tr>
      <tr>
    <td>ObjectPool</td>
    <td><a href = "https://github.com/kelvin-wu13/Logic-Alpha-2ndTest/blob/main/Assets/Scenes/Level%201.unity"> Level 1 - Level 3.</a></td>
    <td>-Handle Bullet gameObject Pool</td>
  </tr>
      <tr>
    <td>Bullet</td>
    <td><a href = "https://github.com/kelvin-wu13/Logic-Alpha-2ndTest/blob/main/Assets/Scenes/Level%201.unity"> Level 1 - Level 3.</a></td>
    <td>-Handle Player and Enemy Bullet Damage and Collision</td>
  </tr>
      <tr>
    <td>GameManager</td>
    <td><a href = "https://github.com/kelvin-wu13/Logic-Alpha-2ndTest/blob/main/Assets/Scenes/Level%201.unity"> Level 1 - Level 3.</a></td>
    <td>-Display PlayerHealth and Display CoinScore</td>
  </tr>
</table>
