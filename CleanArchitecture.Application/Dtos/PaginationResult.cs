﻿namespace CleanArchitecture.Application.Dtos;

public class PaginationResult<TEntity>
{
    public IList<TEntity> Datas { get; set; }

    public int PageNumber { get; set; }

    public int PageSize { get; set; }

    public int TotalPages { get; set; }

    public bool IsFirstPage { get; set; }

    public bool IsLastPage { get; set; }

    // Parametresiz yapıcı
    public PaginationResult()
    {
    }

    // Parametreli yapıcı
    public PaginationResult(IList<TEntity> datas, int pageNumber, int pageSize, int totalCount)
    {
        Datas = datas;
        PageNumber = pageNumber;
        PageSize = pageSize;
        TotalPages = (int)Math.Ceiling((double)totalCount / pageSize);
        IsFirstPage = PageNumber == 1;
        IsLastPage = PageNumber == TotalPages;
    }
}
