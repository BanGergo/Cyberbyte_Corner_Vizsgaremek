@extends('layout')
@section('content')
<div class="container my-5">
    <nav aria-label="breadcrumb">
        <ol class="breadcrumb">
            <li class="breadcrumb-item"><a href="/">Főoldal</a></li>
            <li class="breadcrumb-item active">{{ $termek->termek_nev }}</li>
        </ol>
    </nav>

    <div class="row">
        <!-- Product Images -->
        <div class="col-md-6">
            <div id="productCarousel" class="carousel slide" data-bs-ride="carousel">
                <div class="carousel-inner">
                    @foreach($images as $key => $image)
                        <div class="carousel-item {{ $key == 0 ? 'active' : '' }}">
                            <img src="{{ $image->url }}" class="d-block w-100" alt="{{ $termek->termek_nev }}">
                        </div>
                    @endforeach
                </div>
                @if(count($images) > 1)
                    <button class="carousel-control-prev" type="button" data-bs-target="#productCarousel" data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#productCarousel" data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    </button>
                @endif
            </div>

            <!-- Product Description -->
            <div class="mb-4 mt-4">
                <h5>Termék leírása:</h5>
                <table class="table table-bordered table-striped">
                    @foreach ($tulajdonsagok as $tul)
                        <tr>
                            <th>{{ $tul->tul_nev }}:</th>
                            <td>{{$tul->tul_ertek}}</td>
                        </tr>
                    @endforeach
                </table>
            </div>
        </div>

        <!-- Product Details -->
        <div class="col-md-6">
            <h1 class="mb-4">{{ $termek->termek_nev }}</h1>
            <div class="mb-3">
                <p>Cikkszám: {{ $termek->cikkszam }}</p>
                <span class="h3 text-danger fw-bold">{{ number_format($termek->netto * $termek->afa, 0, ',', ' ') }} Ft</span>
                @if($termek->kedv > 0)
                    <span class="badge bg-danger ms-2">-{{ $termek->kedv }}%</span>
                @endif
            </div>

            <div class="mb-4">
                <h5>Készlet:</h5>
                @if($termek->keszlet > 0)
                    <span class="badge bg-success">Raktáron</span>
                    <span class="ms-2">{{ $termek->keszlet }} db</span>
                @else
                    <span class="badge bg-danger">Nincs raktáron</span>
                @endif
            </div>



            @if($termek->keszlet > 0)
                <form action="/add" method="POST" class="mb-4">
                    @csrf
                    <input type="hidden" name="cikkszam" value="{{ $termek->cikkszam }}">
                    <div class="input-group w-50">
                        <input type="number" name="quantity" class="form-control" value="1" min="1" max="{{ $termek->keszlet }}">
                        <button type="submit" class="btn btn-primary" value="{{ $termek->cikkszam }}" name="cikkszam">
                            <i class="fas fa-cart-plus"></i> Kosárba
                        </button>
                    </div>
                </form>
            @endif



            <!-- Reviews Section -->
            <div class="mt-5">
                @auth
                    <form action="{{ route('products.addReview', $termek->cikkszam) }}" method="POST">
                        @csrf
                        <div class="mb-3">
                            <label for="rating" class="form-label">Értékelés</label>
                            <select name="rating" id="rating" class="form-select" required>
                                <option value="5">5 csillag</option>
                                <option value="4">4 csillag</option>
                                <option value="3">3 csillag</option>
                                <option value="2">2 csillag</option>
                                <option value="1">1 csillag</option>
                            </select>
                        </div>
                        <div class="mb-3">
                            <label for="comment" class="form-label">Vélemény</label>
                            <textarea name="comment" id="comment" class="form-control" required></textarea>
                        </div>
                        <button type="submit" class="btn btn-primary">Vélemény küldése</button>
                    </form>
                @else
                    <div class="alert alert-info">
                        A véleményezéshez kérjük, <a class="btn btn-primary" data-bs-target="#loginModal" data-bs-toggle="modal" id="mobilProfil">jelentkezzen be</a>!
                    </div>
                @endauth

                <h4>Vélemények ({{ count($reviews) }})</h4>
                @foreach($reviews as $review)
                    <div class="card mb-3">
                        <div class="card-body">
                            <h5>{{ $review->username }}</h5>
                            <div class="d-flex justify-content-between">
                                <div>
                                    @for($i = 1; $i <= 5; $i++)
                                        <i class="fas fa-star {{ $i <= $review->ertekeles ? 'text-warning' : 'text-secondary' }}"></i>
                                    @endfor
                                </div>
                                <small class="text-muted">{{ $review->created_at->format('Y.m.d') }}</small>
                            </div>
                            <p class="mt-2 mb-0">{{ $review->review }}</p>
                        </div>
                    </div>
                @endforeach
            </div>
        </div>
    </div>
</div>
@endsection
