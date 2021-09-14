using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dontdestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    public MovieMaler movies;

    private void Awake()
    {
        obj = GameObject.Find("MovieManager");
        movies = obj.GetComponent<MovieMaler>();
        movies.setMovie(gameObject);

    }

    
}
