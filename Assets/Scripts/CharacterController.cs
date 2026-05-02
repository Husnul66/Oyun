using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Header("Hareket Ayarlarý")]
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float lateralSmoothSpeed = 15f;

    [Header("Þerit Koordinatlarý")]
    // Koordinatlarýný buraya tekrar kontrol ederek gir
    // Sol Þerit: -0.4 | Orta Þerit: -0.2 | Sað Þerit: 0
    private float[] xPosition = { -0.4f, -0.2f, 0f };
    private int currentXpositonIndex = 1;

    void Start()
    {
        if (rb == null) rb = GetComponent<Rigidbody>();

        // Rotasyonu tamamen donduruyoruz ki fizik çarpmalarýyla saða sola dönmesin
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && currentXpositonIndex > 0)
        {
            currentXpositonIndex--;
        }
        else if (Input.GetKeyDown(KeyCode.D) && currentXpositonIndex < 2)
        {
            currentXpositonIndex++;
        }
    }

    private void FixedUpdate()
    {
        // 1. Sadece Z eksenindeki ilerleme miktarýný hesapla
        float moveZ = speed * Time.fixedDeltaTime;

        // 2. Sadece X eksenindeki (þerit) yumuþak geçiþi hesapla
        float targetX = xPosition[currentXpositonIndex];
        float nextX = Mathf.Lerp(rb.position.x, targetX, Time.fixedDeltaTime * lateralSmoothSpeed);

        // 3. YENÝ POZÝSYON (Buraya dikkat!)
        // X: Hesaplanan þerit konumu
        // Y: Mevcut yükseklik (zýplama vs. ekleyeceksen rb.position.y kalmalý)
        // Z: Mevcut Z + Ýlerleme miktarý
        Vector3 finalPosition = new Vector3(nextX, rb.position.y, rb.position.z + moveZ);

        // Karakteri taþý
        rb.MovePosition(finalPosition);
    }
}