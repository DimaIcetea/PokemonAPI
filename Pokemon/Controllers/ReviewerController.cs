using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Pokemon.Data;
using Pokemon.Models;
using PokemonReview.Dto;
using PokemonReview.Interfaces;
using PokemonReview.Repository;

namespace PokemonReview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewerController:Controller
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly IReviewerRepository _reviewerRepository;

        public ReviewerController(DataContext context, IMapper mapper, IReviewerRepository reviewerRepository)
        {
            _context = context;
            _mapper = mapper;
            _reviewerRepository = reviewerRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Reviewer>))]
        [ProducesResponseType(400)]
        public IActionResult GetReviewers()
        {
            var reviews = _mapper.Map<List<ReviewerDto>>
                (_reviewerRepository.GetReviewers());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(reviews);
        }

        [HttpGet("{reviewerId}")]
        [ProducesResponseType(200, Type = typeof(Reviewer))]
        [ProducesResponseType(400)]
        public IActionResult GetReviewer(int reviewerId)
        {
            if (!_reviewerRepository.ReviewerExists(reviewerId))
                return NotFound();
            var reviewer = _mapper.Map<ReviewerDto>
                (_reviewerRepository.GetReviewer(reviewerId));
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(reviewer);
        }

        [HttpGet("reviews/{reviewerId}")]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Review>))]
        [ProducesResponseType(400)]
        public IActionResult GetReviewsByReviewer(int reviewerId)
        {
            var reviews = _mapper.Map<List<ReviewDto>>
                (_reviewerRepository.GetReviewsByReviewer(reviewerId));
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(reviews);
        }
    }
}
