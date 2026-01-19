# HW2
## Devlog
### Planning and Code Implementation
#### Ground
- Created a Ground GameObject with a BoxCollider2D.
- The ground is static and serves as the platform for the player to stand on and jump from.

#### Player Jumping
- Created a Player GameObject with a Rigidbody2D and CapsuleCollider2D.
- The `PlayerController.cs` script handles the jumping functionality, with the following details:
  - The `Update()` method detects when the Space key is pressed.
  - A boolean variable `isGrounded` is used to prevent double jumping.
  - The `OnCollisionEnter2D()` method detects collision with the Ground GameObject.

#### Coin Movement and Generation
- The Coin Prefab includes the following components: SpriteRenderer, CircleCollider2D, `Coin.cs`, and `CoinMove.cs`.
- `CoinMove.cs` implements logic to move the coin to the left and destroy the coin GameObject if it goes off-screen.
- `CoinSpawner.cs` generates coins at a fixed Y position, with a random time interval, making the coins appear irregularly on a single horizontal line.

#### Score System
- Created a Canvas with a TextMeshProUGUI component named ScoreText.
- The `ScoreManager.cs` script manages the score display and updates the score when the player collides with a coin.
- `Coin.cs` calls `ScoreManager.instance.AddScore()` when the player collects the coin, then destroys the coin GameObject.


## Open-Source Assets
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
