using UnityEngine;

public class TopDownMovement : MonoBehaviour

{
    private Rigidbody2D _rb;
    private Vector2 _movement;
    [Header("Variables")]
    [SerializeField] private float _speed;

    private void Awake()

    {

    }

    private void OnEnable()

    {

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()

    {

        _rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()

    {

        //Física

        _rb.linearVelocity = _movement * _speed;//Atribuindo o controle à física

    }

    // Update is called once per frame

    void Update()

    {
        //Time.timeScale = 0;

        //Todo o resto

        //Principalmente verificação de botão

        _movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void LateUpdate()

    {

        //Mover a câmera

        //Objetos que seguem

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out ITouchable target))
        {
            target.Active();
        }
    }

    private void OnBecameInvisible()

    {

        //Quando o objeto com sprite sair das câmeras

    }

    private void OnBecameVisible()

    {

        //Quando o objeto com sprite entrar nas câmeras

    }

    private void OnApplicationQuit()

    {

        //Quando o jogo fecha

    }

    private void OnApplicationFocus(bool focus)

    {

        if (focus)

        {

            //Algo acontece se o jogador volta para o jogo

        }

        else

        {

            //Algo acontece se o jogador não está no jogo

        }

    }

    private void OnApplicationPause(bool pause)

    {

        if (pause)

        {

            //0 timeScale está 0

        }
        else

        {

            //0 timeScale está 1

        }

    }

    private void OnDestroy()

    {

        //Nunca usem Instatiate aqui

    }

    private void OnDisable()

    {

    }

    private void OnDrawGizmos()

    {

        //"Update" dos elementos de editor

    }

    private void OnMouseDown()

    {

        //Quando clica no colisor

    }

    private void OnMouseEnter()

    {

        //Quando o cursor do mouse entra no colisor

    }

    private void OnMouseDrag()

    {

        //Quando o clique está pressionado no colisor

    }

    private void OnMouseExit()

    {

        //Quando o cursor do mouse sai da colisão

    }

    private void OnMouseOver()

    {

        //Quando o cursor do mouse está sobre a colisão

    }

    private void OnMouseUp()

    {

        //Quando o clique é solto da colisão

    }

    private void OnTransformChildrenChanged()

    {

        //Quando o filho muda

    }

    private void OnTransformParentChanged()

    {

        //Quando o pai muda

    }

    private void OnValidate()

    {

        //Quando algum valor é alterado no inspector no modo editor

    }

}

