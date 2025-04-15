using System;
using API.DTOs;
using API.Models;

namespace API.Mapper;

public class TCGMapper : ITCGMapper
{
    public TCGMapper()
    {

    }

    public MemberDto MapTo(AppUser MapFrom, MemberDto MapTo)
    {
        return new MemberDto
        {

        };
    }

    public PhotoDto MapTo(Photo MapFrom, PhotoDto MapTo)
    {
        return new PhotoDto
        {

        };
    }
}